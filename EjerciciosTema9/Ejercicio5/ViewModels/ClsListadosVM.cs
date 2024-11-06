using Ejercicio5.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.ViewModels
{
    /// <summary>
    /// Clase que sera la ViewModel de las pantallas MainPage y Detalles
    /// </summary>
    public class ClsListadosVM
    {
        private ObservableCollection<ClsPersona> listadoPersonas = ClsListados.ObtenerListadoPersonas();
        public ObservableCollection<ClsPersona> ListadoPersonas
        {
            get { return listadoPersonas; }
        }
    }
}
