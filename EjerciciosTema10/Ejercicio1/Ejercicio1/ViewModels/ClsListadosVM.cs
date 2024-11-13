using Ejercicio1.Models;
using Ejercicio1.ViewModels.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        private ClsPersona personaSeleccionada;
        private DelegateCommand eliminarCommand;

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
        public ClsListadosVM()
        {
            try
            {
                eliminarCommand = new DelegateCommand(EliminarCommand_Executed, EliminarCommand_CanExecute);
                listadoPersonas = new ObservableCollection<ClsPersona>(ClsListados.ObtenerListadoPersonas());
            }
            catch (Exception ex)
            {
                //TODO Mandar a una pagina de error
            }
        }

        private void EliminarCommand_Executed()
        {
            // TODO Codigo que queremos que ocurra cuando se pulse el boton de eliminar
        }

        private bool EliminarCommand_CanExecute()
        {
            bool sePuedeBorrar = true;
            if (personaSeleccionada == null)
            {
                sePuedeBorrar = false;
            }
            return sePuedeBorrar;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}
