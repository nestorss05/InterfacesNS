using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionV2.ViewModels
{
    /// <summary>
    /// ViewModel de Edad
    /// </summary>
    public class EdadVM : INotifyPropertyChanged
    {

        #region Atributos
        private DateTime fechaNac;
        private int edad;
        #endregion

        #region PropiedadesPublicas
        public DateTime FechaNac { 
            get { return fechaNac; } 
            set { fechaNac = value; NotifyPropertyChanged("Edad"); }
        }
        public int Edad { 
            get { return CalcularEdad(); }
        }
        #endregion

        #region Metodos
        private int CalcularEdad()
        {
            int edad = DateTime.Now.Year - fechaNac.Year;
            if ((DateTime.Now.Month < fechaNac.Month) || (DateTime.Now.Month == fechaNac.Month && DateTime.Now.Day < fechaNac.Day))
            {
                edad--;
            }
            return edad;
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
