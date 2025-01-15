using Ejercicio1.ViewModels.Utilidades;
using Ejercicio2DAL;
using Ejercicio2DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Ejercicio2.ViewModels
{
    public class ListadoVM: INotifyPropertyChanged
    {

        #region Atributos
        private ObservableCollection<ClsPersona>? listadoPersonas;
        private ClsPersona? personaSeleccionada;
        private DelegateCommand crearCommand;
        private DelegateCommand eliminarCommand;
        private bool sinCargar;
        private HttpStatusCode httpRes;
        #endregion

        #region Properties
        public ObservableCollection<ClsPersona>? ListadoPersonas
        {
            get { return listadoPersonas; }
            set
            {
                listadoPersonas = value;
                NotifyPropertyChanged("ListadoPersonas");
            }
        }
        public ClsPersona? PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                personaSeleccionada = value;
                eliminarCommand.RaiseCanExecuteChanged();
                NotifyPropertyChanged("PersonaSeleccionada");
            }
        }
        public bool SinCargar
        {
            get { return sinCargar; }
            set
            {
                sinCargar = value;
                NotifyPropertyChanged("SinCargar");
            }
        }
        public DelegateCommand CrearCommand
        {
            get { return crearCommand; }
        }
        public DelegateCommand EliminarCommand
        {
            get { return eliminarCommand; }
        }
        #endregion

        #region Constructores
        public ListadoVM()
        {
            crearCommand = new DelegateCommand(CrearCommand_Executed);
            eliminarCommand = new DelegateCommand(EliminarCommand_Executed, EliminarCommand_CanExecute);
            CargarLista();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que carga el listado de personas hacia el ViewModel
        /// Pre: nada
        /// Post: nada
        /// </summary>
        private async void CargarLista()
        {
            SinCargar = true;
            List<ClsPersona> personasEncontradas = await ClsListadoDAL.GetListadoDAL();
            if (listadoPersonas == null)
            {
                listadoPersonas = new ObservableCollection<ClsPersona>();
            }
            else
            {
                listadoPersonas.Clear();
            }
            foreach (ClsPersona persona in personasEncontradas)
            {
                listadoPersonas.Add(persona);
            }
            SinCargar = false;
            NotifyPropertyChanged("ListadoPersonas");
        }

        /// <summary>
        /// Metodo que llama al metodo de creacion de personas de la capa DAL
        /// Pre: nada
        /// Post: nada
        /// </summary>
        private async void CrearCommand_Executed()
        {
            // Relleno de datos acerca de la persona
            ClsPersona persona = new ClsPersona();

            persona.nombre = await Application.Current.MainPage.DisplayPromptAsync("Insercion de persona", "Introduce el nombre:");
            persona.apellidos = await Application.Current.MainPage.DisplayPromptAsync("Insercion de persona", "Introduce los apellidos:");
            persona.telefono = await Application.Current.MainPage.DisplayPromptAsync("Insercion de persona", "Introduce el teléfono:");
            persona.direccion = await Application.Current.MainPage.DisplayPromptAsync("Insercion de persona", "Introduce la dirección:");
            persona.foto = await Application.Current.MainPage.DisplayPromptAsync("Insercion de persona", "Introduce la URL o ruta de la foto:");

            string fechaText = await Application.Current.MainPage.DisplayPromptAsync("Insercion de persona", "Introduce la fecha de nacimiento (yyyy-MM-dd):");
            persona.fechaNacimiento = DateTime.TryParse(fechaText, out DateTime fecha) ? fecha : DateTime.MinValue;

            string idDepartamentoText = await Application.Current.MainPage.DisplayPromptAsync("Insercion de persona", "Introduce el ID del departamento:");
            persona.idDepartamento = int.TryParse(idDepartamentoText, out int idDepartamento) ? idDepartamento : 0;

            // Confirmacion de creacion de usuario y su creacion
            bool conf = await Application.Current.MainPage.DisplayAlert("Insercion de persona", "¿Estas seguro?", "Si", "No");
            if (conf)
            {
                httpRes = await ClsListadoDAL.insertaPersonaDAL(persona);
                if ((int)httpRes == 201 || (int)httpRes == 200)
                {
                    await Application.Current.MainPage.DisplayAlert("Informacion", "La persona ha sido creada", "Aceptar");
                    CargarLista();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Ha ocurrido un error.", "Aceptar");
                }
            }

        }

        /// <summary>
        /// Metodo que llama al metodo de eliminacion de personas de la capa DAL
        /// Pre: nada
        /// Post: nada
        /// </summary>
        private async void EliminarCommand_Executed()
        {
            bool res = await Application.Current.MainPage.DisplayAlert("Confirmación", "¿Estás seguro de realizar esta acción?", "Sí", "No");
            if (res)
            {
                httpRes = await ClsListadoDAL.eliminarPersonaDAL(personaSeleccionada.id);
                if ((int)httpRes == 200)
                {
                    await Application.Current.MainPage.DisplayAlert("Informacion", "La persona ha sido eliminada", "Aceptar");
                    CargarLista();
                    personaSeleccionada = null;
                    NotifyPropertyChanged("PersonaSeleccionada");
                } 
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Ha ocurrido un error.", "Aceptar");
                }
            }
        }

        /// <summary>
        /// Metodo que comprueba si se puede eliminar un usuario o no
        /// Pre: nada
        /// Post: siempre devuelve una booleana indicando la activacion del boton de eliminacion
        /// </summary>
        /// <returns>Existencia de una persona seleccionada</returns>
        private bool EliminarCommand_CanExecute()
        {
            bool res = false;
            if (personaSeleccionada is not null)
            {
                res = true;
            }
            return res;
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion

    }
}
