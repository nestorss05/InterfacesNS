namespace Ejercicio1ENT
{
    public class ClsPersona
    {
        public string Nombre {  get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNac {  get; set; }
        public ClsPersona() { }
        public ClsPersona(string nombre, string apellidos, DateTime fechaNac)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNac = fechaNac;
        }
    }
}
