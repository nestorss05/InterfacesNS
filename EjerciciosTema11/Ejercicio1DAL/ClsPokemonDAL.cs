using Ejercicio1ENT;
using Newtonsoft.Json;

namespace Ejercicio1DAL
{
    public class ClsPokemonDAL
    {
        /// <summary>
        /// Metodo que devuelve un listado de pokemons
        /// Pre: offset y limite para la API
        /// Post: puede devolver un listado de los 20 primeros pokemons o te puede mandar un AlCarajoException (ojala)
        /// </summary>
        /// <param name="offset">Posicion donde la API empezara a buscar</param>
        /// <param name="limit">Limite de pokemons por lista</param>
        /// <returns>Listado de pokemons</returns>
        public static async Task<List<ClsPokemon>> GetPokemonsDAL(int offset, int limit)
        {
            string miCadenaUrl = ClsConexion.getUriBase(offset, limit);
            Uri miUri = new Uri($"{miCadenaUrl}");
            List<ClsPokemon> listadoPokemons = new List<ClsPokemon>();
            HttpClient mihttpClient = new HttpClient();

            try
            {
                HttpResponseMessage miCodigoRespuesta = await mihttpClient.GetAsync(miUri);

                if (miCodigoRespuesta.IsSuccessStatusCode)
                {

                    string textoJsonRespuesta = await mihttpClient.GetStringAsync(miUri);

                    //JsonConvert necesita using Newtonsoft.Json;
                    PokeResponse res = JsonConvert.DeserializeObject<PokeResponse>(textoJsonRespuesta);

                    if (res?.Results != null)
                    {
                        listadoPokemons = res.Results;
                    }

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

            return listadoPokemons;

        }

    }
}
