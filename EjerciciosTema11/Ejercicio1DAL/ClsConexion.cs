using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1DAL
{
    public class ClsConexion
    {
        /// <summary>
        /// Metodo que devuelve la URI de la API
        /// Pre: numeros offset y limite
        /// Post: siempre devuelve la URI de la PokeAPI acorde a los parametros pasados
        /// </summary>
        /// <returns>URI de la PokeAPI</returns>
        public static string getUriBase(int offset, int limit)
        {
            string url = "https://pokeapi.co/api/v2/pokemon?limit="; 
            url += limit.ToString();
            url += "&offset=";
            url += offset.ToString();
            return url;
        }
    }
}
