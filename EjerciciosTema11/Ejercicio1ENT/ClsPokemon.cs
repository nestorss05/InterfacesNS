namespace Ejercicio1ENT
{
    public class ClsPokemon
    {
        public required string nombre { get; set; }
        public required string url { get; set; }

        public ClsPokemon() { }

        public ClsPokemon(string nombre, string url)
        {
            this.nombre = nombre;
            this.url = url;
        }

    }
}
