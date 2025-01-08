using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2DAL
{
    public class ClsConexion
    {
        /// <summary>
        /// Metodo que devuelve la URI de la API
        /// Pre: nada
        /// Post: siempre devuelve la URI de la PokeAPI
        /// </summary>
        /// <returns>URI de la PokeAPI</returns>
        public static string getUriBase()
        {
            string url = "https://nestorsanchezasp.azurewebsites.net/API/Personas";
            return url;
        }
    }
}
