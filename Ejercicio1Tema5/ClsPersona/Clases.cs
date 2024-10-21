namespace BibliotecaClases
{
    public class ClsPersona
    {
        #region atributos
        private String nombre;
        private String apellidos;
        #endregion

        #region propiedades

        public String Nombre { get; set; }
        public String Apellidos { get; set; }

        #endregion

        #region constructores
        public ClsPersona()
        {
            Nombre = "";
            Apellidos = "";
        }
        public ClsPersona(String nombre, String apellido)
        {
            Nombre = nombre;
            Apellidos = apellido;
        }
        #endregion

    }
}
