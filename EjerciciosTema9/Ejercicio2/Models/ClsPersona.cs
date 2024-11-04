using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    /// <summary>
    /// Clase que contiene los datos de una persona
    /// </summary>
    public class ClsPersona : INotifyPropertyChanged
    {
        #region Atributos
        private string nombre { get; set; }
        #endregion

        #region PropiedadesPublicas
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; NotifyPropertyChanged("NombreCompleto"); }
        }

        public string NombreCompleto
        {
            get { return nombre; }
        }
        #endregion

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        
        }
        #endregion

    }
}
