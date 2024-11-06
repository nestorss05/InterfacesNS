using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio3ENT
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
