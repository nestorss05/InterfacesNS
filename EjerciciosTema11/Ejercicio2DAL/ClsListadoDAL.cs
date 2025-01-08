using Ejercicio2ENT;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ejercicio2DAL
{
    public class ClsListadoDAL
    {
        /// <summary>
        /// Metodo que devuelve un listado de personas
        /// Pre: nada
        /// Post: Si la conexion es exitosa, siempre devolvera un listado de personas
        /// </summary>
        /// <returns>Listado de personas</returns>
        public static async Task<List<ClsPersona>> GetListadoDAL()
        {
            string miCadenaUrl = ClsConexion.getUriBase();
            Uri miUri = new Uri($"{miCadenaUrl}");
            List<ClsPersona> listadoPersonas = new List<ClsPersona>();
            HttpClient mihttpClient = new HttpClient();

            try
            {
                HttpResponseMessage miCodigoRespuesta = await mihttpClient.GetAsync(miUri);

                if (miCodigoRespuesta.IsSuccessStatusCode)
                {

                    string textoJsonRespuesta = await mihttpClient.GetStringAsync(miUri);

                    //JsonConvert necesita using Newtonsoft.Json;
                    listadoPersonas = JsonConvert.DeserializeObject<List<ClsPersona>>(textoJsonRespuesta);

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mihttpClient.Dispose();
            }

            return listadoPersonas;
        }
    }
}
