namespace ExamenNS_ENT
{
    public class ClsMision
    {
        public int IdMision {  get; set; }
        public string NombreMision { get; set; }
        public int Dificultad {  get; set; }
        public ClsMision(int idMision, string nombreMision, int dificultad)
        {
            IdMision = idMision;
            NombreMision = nombreMision;
            Dificultad = dificultad;
        }
    }
}
