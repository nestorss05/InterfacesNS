using Ejercicio1ENT;
using Newtonsoft.Json;

namespace Ejercicio1DAL
{
    public class ClsPokemonDAL
    {
        /// <summary>
        /// Metodo que devuelve un listado de pokemons
        /// Pre: nada
        /// Post: puede devolver un listado de los 20 primeros pokemons o te puede mandar un AlCarajoException (ojala)
        /// </summary>
        /// <returns>Listado de pokemons</returns>
        public static async Task<List<ClsPokemon>> GetPokemonsDAL()
        {

            //Pido la cadena de la Uri al método estático
            string miCadenaUrl = ClsConexion.getUriBase();
            Uri miUri = new Uri($"{miCadenaUrl}Personas");
            List<ClsPokemon> listadoPokemons = new List<ClsPokemon>();
            HttpClient mihttpClient;
            HttpResponseMessage miCodigoRespuesta;
            string textoJsonRespuesta;

            //Instanciamos el cliente Http
            mihttpClient = new HttpClient();

            try

            {

                miCodigoRespuesta = await mihttpClient.GetAsync(miUri);
                if (miCodigoRespuesta.IsSuccessStatusCode)
                {

                    textoJsonRespuesta = await mihttpClient.GetStringAsync(miUri);
                    mihttpClient.Dispose();

                    //JsonConvert necesita using Newtonsoft.Json;
                    listadoPokemons = JsonConvert.DeserializeObject<List<ClsPokemon>>(textoJsonRespuesta);

                }

            }
            catch (Exception ex)
            {
                // TODO: AlCarajoException
                throw ex;
            }

            return listadoPokemons;

        }

    }
}
