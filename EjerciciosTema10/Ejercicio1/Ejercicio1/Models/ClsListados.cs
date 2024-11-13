using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    /// <summary>
    /// Clase que almacena listas
    /// </summary>
    public class ClsListados
    {
        /// <summary>
        /// Funcion que almacena la lista de personas
        /// </summary>
        /// <returns></returns>
        public static List<ClsPersona> ObtenerListadoPersonas()
        {
            return new List<ClsPersona>
            {
                new ClsPersona(1, "Eusebio", "Fernandez", new DateTime(1995, 10, 21), "https://thispersondoesnotexist.com/", "Su calle 94", 333444555),
                new ClsPersona(2, "Alejandro", "Rios", new DateTime(1998, 11, 18), "https://thispersondoesnotexist.com/", "Su avenida 234", 123455789),
                new ClsPersona(3, "Javier", "Castillo", new DateTime(2002, 2, 20), "https://thispersondoesnotexist.com/", "Avenida de la Constitucion 235", 123667897),
                new ClsPersona(4, "Camila", "Morales", new DateTime(2003, 3, 21), "https://thispersondoesnotexist.com/", "Su calle 22", 231564367),
                new ClsPersona(5, "Lucia", "Sanchez", new DateTime(2004, 12, 1), "https://thispersondoesnotexist.com/", "Calle Mordor S/N", 124268777),
                new ClsPersona(6, "Miguel", "Torres", new DateTime(2006, 2, 22), "https://thispersondoesnotexist.com/", "Avenida de las Razas 22", 576546543)
            };
        }

    }
}
