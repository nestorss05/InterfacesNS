using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Ent
{
    /// <summary>
    /// Clase que guarda las propiedades de la persona
    /// </summary>
    public class clsPersona
    {
        public int id { get; set; }
        public required string nombre { get; set; }
        public required string apellidos { get; set; }
        public required string fechaNac { get; set; }
    }
}
