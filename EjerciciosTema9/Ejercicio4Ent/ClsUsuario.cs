namespace Ejercicio4Ent
{

    /// <summary>
    /// Clase con contenido del usuario
    /// </summary>
    public class ClsUsuario
    {
        
        private String _nombre = "";
        private String _apellidos = "";

        public ClsUsuario() { }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public String Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value;  }
        }
    }
}
