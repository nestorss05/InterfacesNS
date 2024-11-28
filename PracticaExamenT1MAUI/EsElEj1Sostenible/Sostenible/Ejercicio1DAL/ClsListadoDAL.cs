using Ejercicio1ENT;

namespace Ejercicio1DAL
{
    public class ClsListadoDAL
    {
        /// <summary>
        /// Funcion que devuelve una lista completa de personas
        /// <pre>Ninguna</pre>
        /// <post>Siempre devuelve una lista completa de personas</post>
        /// </summary>
        /// <returns>Lista completa de personas</returns>
        public static List<ClsPersona> ListadoPersonasDAL()
        {
            return new List<ClsPersona>() { 
                new ClsPersona("Nestor", "Sanchez", new DateTime(2005, 11, 15)),
                new ClsPersona("Diego Jose", "Perez", new DateTime(2003, 11, 20)),
                new ClsPersona("Diego", "Ruiperez", new DateTime(2005, 08, 10)),
                new ClsPersona("Ruben", "Palomo", new DateTime(2005, 10, 21)),
                new ClsPersona("Lucas", "Salas", new DateTime(2006, 12, 01))
            };
        }
    }
}
