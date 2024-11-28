using Ejercicio1.ViewModels.Utilidades;
using EjercicioArtistasBL;
using EjercicioArtistasENT;
using EjercicioArtistasMAUI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArtistasMAUI.ViewModels
{
    [QueryProperty(nameof(CancionSeleccionada), "CancionSeleccionada")]
    public class ClsListadoVM: INotifyPropertyChanged
    {

        private List<ClsArtista>artistas;
        private List<ClsCancion>canciones;
        private ClsArtista artistaSeleccionado;
        private ClsCancion cancionSeleccionada;
        private int cuentaCanciones;
        private DelegateCommand comandoDetalles;
        private DelegateCommand comandoVolver;

        public List<ClsArtista> Artistas { get { return artistas; } }
        public List<ClsCancion> Canciones
        {
            get { return canciones; }
            set { canciones = value; NotifyPropertyChanged("Canciones"); }
        }
        public ClsArtista ArtistaSeleccionado
        {
            get { return artistaSeleccionado; }
            set 
            { 
                artistaSeleccionado = value; 
                NotifyPropertyChanged("ArtistaSeleccionado");
                ObtenerListadoCanciones();
            }
        }
        public ClsCancion CancionSeleccionada
        {
            get { return cancionSeleccionada; }
            set 
            { 
                cancionSeleccionada = value; 
                NotifyPropertyChanged("CancionSeleccionada");
                comandoDetalles.RaiseCanExecuteChanged();
            }
        }
        public int CuentaCanciones
        {
            get { return cuentaCanciones; }
            set { cuentaCanciones = value; NotifyPropertyChanged("CuentaCanciones"); }
        }
        public DelegateCommand ComandoDetalles
        {
            get { return comandoDetalles; }
        }

        public DelegateCommand ComandoVolver
        {
            get { return comandoVolver; }
        }

        public ClsListadoVM()
        {
            artistas = ClsListadosBL.ListadoArtistasBL();
            comandoDetalles = new DelegateCommand(ComandoDetalles_Executed, ComandoDetalles_CanExecute);
            comandoVolver = new DelegateCommand(ComandoVolver_Executed);
        }

        /// <summary>
        /// Metodo que obtiene el listado de canciones de la capa BL y lo guarda en canciones
        /// Tambien guarda el recuento de canciones en cuentaCanciones
        /// Pre: Ninguna
        /// Post: Ninguna
        /// </summary>
        private void ObtenerListadoCanciones()
        {
            Canciones = ClsListadosBL.ListadoCancionesBL(artistaSeleccionado.IdArtista);
            cuentaCanciones = canciones.Count();
        }

        /// <summary>
        /// Metodo que te dirige a la pantalla de Detalles si estas en MainPage
        /// Pre: Ninguna
        /// Post: Ninguna
        /// </summary>
        private async void ComandoDetalles_Executed()
        {
            if (Shell.Current.CurrentPage is MainPage)
            {
                var navigationParameter = new ShellNavigationQueryParameters
            {
                { "CancionSeleccionada", cancionSeleccionada }
            };
                await Shell.Current.GoToAsync("//DetallesCancion", navigationParameter);
            }
        }

        /// <summary>
        /// Metodo que comprueba si se puede activar o no el boton de Detalles
        /// Pre: Ninguna
        /// Post: Siempre devuelve un booleano
        /// </summary>
        /// <returns>Indicador acerca de la activacion del boton de detalles</returns>
        private bool ComandoDetalles_CanExecute()
        {
            bool res = false;
            if (cancionSeleccionada is not null)
            {
                res = true;
            }
            return res;
        }

        /// <summary>
        /// Metodo que te dirige a MainPage si no estas en este
        /// Pre: Nada
        /// Post: Nada
        /// </summary>
        private async void ComandoVolver_Executed()
        {
            if (Shell.Current.CurrentPage is not MainPage)
            {
                await Shell.Current.GoToAsync("//MainPage");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
