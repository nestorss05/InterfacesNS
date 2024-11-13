using Ejercicio1.Models;
using Ejercicio1.ViewModels.Utilidades;
using Ejercicio1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.ViewModels
{
    /// <summary>
    /// Clase que sera la ViewModel de las pantallas MainPage y Detalles
    /// </summary>
    public class ClsListadosVM : INotifyPropertyChanged
    {

        private ObservableCollection<ClsPersona> listadoPersonas;
        private ObservableCollection<ClsPersona> listadoPersonasBase;
        private ClsPersona personaSeleccionada;
        private DelegateCommand eliminarCommand;
        private DelegateCommand searchCommand;
        private String texto;

        public ObservableCollection<ClsPersona> ListadoPersonas
        {
            get { return listadoPersonas; }
        }
        public ClsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                personaSeleccionada = value;
                eliminarCommand.RaiseCanExecuteChanged();
                NotifyPropertyChanged("PersonaSeleccionada");
            }
        }
        public DelegateCommand EliminarCommand
        {
            get
            {
                return eliminarCommand;
            }
        }

        public DelegateCommand SearchCommand
        {
            get
            {
                return searchCommand;
            }
        }

        public string Texto
        {
            get
            {
                return texto;
            }
            set
            {
                texto = value;
                searchCommand.RaiseCanExecuteChanged();
                NotifyPropertyChanged("Texto");

                if (string.IsNullOrEmpty(texto))
                {
                    listadoPersonas.Clear();
                    foreach (ClsPersona persona in listadoPersonasBase)
                    {
                        listadoPersonas.Add(persona);
                    }
                }
            }
        }

        public ClsListadosVM()
        {
            try
            {
                eliminarCommand = new DelegateCommand(EliminarCommand_Executed, EliminarCommand_CanExecute);
                listadoPersonasBase = new ObservableCollection<ClsPersona>(ClsListados.ObtenerListadoPersonas());
                listadoPersonas = new ObservableCollection<ClsPersona>(listadoPersonasBase);
                searchCommand = new DelegateCommand(SearchCommand_Executed, SearchCommand_CanExecute);
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }

        }

        /// <summary>
        /// Metodo que pregunta al usuario sobre la eliminacion de un usuario
        /// </summary>
        private async void EliminarCommand_Executed()
        {
            bool answer = await Application.Current.MainPage.DisplayAlert("Pregunta", "¿Estas seguro de eliminar este usuario?", "Si", "No");
            if (answer)
            {
                listadoPersonas.Remove(personaSeleccionada);
                listadoPersonasBase.Remove(personaSeleccionada);
                personaSeleccionada = null;
            }
        }

        /// <summary>
        /// Metodo que ejecuta el servicio de busqueda de usuarios
        /// </summary>
        private void SearchCommand_Executed()
        {
            if (string.IsNullOrEmpty(Texto))
            {
                listadoPersonas.Clear();
                foreach (ClsPersona persona in listadoPersonasBase)
                {
                    listadoPersonas.Add(persona);
                }
            }
            else
            {
                List<ClsPersona> listaFiltrada = listadoPersonasBase
                    .Where(per => per.Nombre.Contains(Texto) || per.Apellidos.Contains(Texto))
                    .ToList();
                listadoPersonas.Clear();
                foreach (ClsPersona persona in listaFiltrada)
                {
                    listadoPersonas.Add(persona);
                }
            }
        }

        /// <summary>
        /// Metodo que comprueba si una persona esta seleccionada o no, asi habilitar / deshabilitar el boton de borrado de usuario
        /// </summary>
        /// <returns>Booleana que indica si una persona esta seleccionada o no</returns>
        private bool EliminarCommand_CanExecute()
        {
            return personaSeleccionada != null;
        }

        /// <summary>
        /// Metodo que comprueba si la cadena Texto no esta vacia, asi habilitar / deshabilitar el boton de busqueda
        /// </summary>
        /// <returns>Booleana que indica si la cadena Texto esta vacia o no</returns>
        private bool SearchCommand_CanExecute()
        {
            return !string.IsNullOrEmpty(Texto);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}
