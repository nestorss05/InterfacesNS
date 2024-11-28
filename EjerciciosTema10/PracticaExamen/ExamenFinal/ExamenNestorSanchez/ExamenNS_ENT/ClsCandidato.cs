namespace ExamenNS_ENT
{
    public class ClsCandidato
    {
        public int IdCandidato { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad {  get; set; }
        public string Pais { get; set; }
        public string Direccion {  get; set; }
        public int Telefono { get; set; }
        public double Recompensa { get; set; }

        public ClsCandidato(int idCandidato, string nombre, string apellidos, int edad, string pais, string direccion, int telefono, double recompensa)
        {
            IdCandidato = idCandidato;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Pais = pais;
            Direccion = direccion;
            Telefono = telefono;
            Recompensa = recompensa;
        }
    }
}
