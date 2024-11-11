using Ejercicio5b.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5b.ViewModels
{
    /// <summary>
    /// Clase que sera la ViewModel de las pantallas MainPage y Detalles
    /// </summary>
    public class ClsListadosVM : INotifyPropertyChanged
    {

        private ObservableCollection<ClsPersona> listadoPersonas;
        private ClsPersona personaSeleccionada;

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
                NotifyPropertyChanged("PersonaSeleccionada");
            }
        }
        public ClsListadosVM()
        {
            try
            {
                listadoPersonas = new ObservableCollection<ClsPersona>(ClsListados.ObtenerListadoPersonas());
            }
            catch (Exception ex)
            {
                //TODO Mandar a una pagina de error
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}
