using Ejercicio2DTO;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;

namespace Ejercicio2DAL
{
    public class ClsListadoDAL
    {

        private static ILogger logger;

        /// <summary>
        /// Metodo que devuelve un listado de personas
        /// Pre: nada
        /// Post: Si la conexion es exitosa, siempre devolvera un listado de personas
        /// </summary>
        /// <returns>Listado de personas</returns>
        public static async Task<List<ClsPersona>> GetListadoDAL()
        {
            string miCadenaUrl = ClsConexion.getUriBase() + "/Personas";
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
                logger.LogError(ex, "ERROR: No se ha podido conectar al servidor. Intentelo mas tarde.");
                throw;
            }
            finally
            {
                mihttpClient.Dispose();
            }

            return listadoPersonas;
        }

        /// <summary>
        /// Metodo que llama a la API para insertar una persona en la BD
        /// Pre: siempre se inserta una persona a crear
        /// Post: siempre devuelve el codigo que da la API
        /// </summary>
        /// <param name="persona">Persona a añadir</param>
        /// <returns>Codigo de respuesta que da la API</returns>
        public static async Task<HttpStatusCode> insertaPersonaDAL(ClsPersona persona)
        {

            HttpClient mihttpClient = new HttpClient();
            string datos;
            HttpContent contenido;
            string miCadenaUrl = ClsConexion.getUriBase() + "/Personas";
            Uri miUri = new Uri($"{miCadenaUrl}");

            //Usaremos el Status de la respuesta para comprobar si ha borrado
            HttpResponseMessage miRespuesta = new HttpResponseMessage();

            try
            {
                datos = JsonConvert.SerializeObject(persona);
                contenido = new StringContent(datos, System.Text.Encoding.UTF8, "application/json");
                miRespuesta = await mihttpClient.PostAsync(miUri, contenido);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ERROR: No se ha podido conectar al servidor. Intentelo mas tarde.");
                throw;
            }

            return miRespuesta.StatusCode;

        }

        /// <summary>
        /// Metodo que llama a la API para eliminar una persona de la BD
        /// Pre: siempre se inserta la ID de la persona a crear
        /// Post: siempre devuelve el codigo que da la API
        /// </summary>
        /// <param name="idPersona">ID de la persona a añadir</param>
        /// <returns>Codigo de respuesta que da la API</returns>
        public static async Task<HttpStatusCode> eliminarPersonaDAL(int idPersona)
        {
            HttpClient mihttpClient = new HttpClient();
            string datos;
            HttpContent contenido;
            string miCadenaUrl = ClsConexion.getUriBase() + "/Personas/" + idPersona;
            Uri miUri = new Uri($"{miCadenaUrl}");

            //Usaremos el Status de la respuesta para comprobar si ha borrado
            HttpResponseMessage miRespuesta = new HttpResponseMessage();

            try
            {
                miRespuesta = await mihttpClient.DeleteAsync(miUri);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ERROR: No se ha podido conectar al servidor. Intentelo mas tarde.");
                throw;
            }

            return miRespuesta.StatusCode;
        }

    }
}
