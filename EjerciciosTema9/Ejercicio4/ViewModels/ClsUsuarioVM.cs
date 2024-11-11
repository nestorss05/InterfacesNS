using Ejercicio4Ent;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio4.ViewModels
{
    public class ClsUsuarioVM : INotifyPropertyChanged
    {
        #region Atributos
        private ClsUsuario usuario = new ClsUsuario();
        #endregion

        #region PropiedadesPublicas
        public String Nombre
        {
            get { return NombreN(); }
            set { usuario.Nombre = value; NotifyPropertyChanged(); }
        }
        public String Apellidos
        {
            get { return ApellidosN(); }
            set { usuario.Apellidos = value; NotifyPropertyChanged(); }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para alterar el apellido con poner N en el nombre
        /// </summary>
        /// <returns>Mismo usuario</returns>
        private String NombreN()
        {
            if (usuario.Nombre.Contains("n"))
            {
                Apellidos = "";
            }
            return usuario.Nombre;
        }

        /// <summary>
        /// Metodo para alterar el nombre con poner N en el apellido
        /// </summary>
        /// <returns>Mismo apellido</returns>
        private String ApellidosN()
        {
            if (usuario.Apellidos.Contains("n"))
            {
                Nombre = "";
            }
            return usuario.Apellidos;
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
