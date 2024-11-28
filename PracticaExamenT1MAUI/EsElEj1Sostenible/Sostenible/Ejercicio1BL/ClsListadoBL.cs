using Ejercicio1DAL;
using Ejercicio1ENT;

namespace Ejercicio1BL
{
    public class ClsListadoBL
    {
        /// <summary>
        /// Funcion que devuelve una lista completa de personas
        /// <pre>Ninguna</pre>
        /// <post>Siempre devuelve una lista completa de personas</post>
        /// </summary>
        /// <returns>Lista completa de personas</returns>
        public static List<ClsPersona> ListadoPersonasBL()
        {
            List<ClsPersona> personas = ClsListadoDAL.ListadoPersonasDAL();
            return personas;
        }
    }
}
