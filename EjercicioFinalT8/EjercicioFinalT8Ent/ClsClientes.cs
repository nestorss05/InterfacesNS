namespace EjercicioFinalT8Ent
{

    /// <summary>
    /// Clase que guarda las propiedades de los clientes
    /// </summary>
    public class ClsClientes
    {
        public int id { get; set; }
        public required string nombre { get; set; }
        public required string direccion { get; set; }
        public int telefono { get; set; }
        public required string ingeniero { get; set; }
        public bool apto { get; set; }
    }
}
