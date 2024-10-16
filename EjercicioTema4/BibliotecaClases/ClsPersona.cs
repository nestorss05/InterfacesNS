namespace BibliotecaClases
{
    public class ClsPersona
    {
        #region atributos
        private String apellido;
        private DateTime fechaNac;
        #endregion

        #region propiedades

        public String Nombre{ get; set; }
        public String Apellido{ get; set; }
        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { 
                if (value.Year >= 1900)
                {
                    fechaNac = value;
                }
            }
        }

        public int Edad
        {
            get { return DateTime.Now.Year - FechaNac.Year; }
        }
        #endregion

        #region constructores
        public ClsPersona() {
            Nombre = "Hector";
            Apellido = "Salamanca";
            this.fechaNac = new DateTime(1983, 10, 24);
        }
        public ClsPersona(String nombre, String apellido, DateTime fechaNac)
        {
            Nombre = nombre;
            Apellido = apellido;
            this.fechaNac = fechaNac;
        }
        #endregion

    }
}
