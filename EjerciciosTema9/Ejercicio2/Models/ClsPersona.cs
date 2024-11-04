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
        private string nombre { get; set; }

        public string Nombre
        {
            get { return nombre; }
        }

        public string NombreCompeto
        {
            get { return nombre; }
        }

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertychanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
