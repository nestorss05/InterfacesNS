using EjercicioArtistasDAL;
using EjercicioArtistasENT;

namespace EjercicioArtistasBL
{
    public class ClsListadosBL
    {
        /// <summary>
        /// Devuelve un listado de artistas completo
        /// </summary>
        /// <pre>Nada</pre>
        /// <post>Siempre devuelve un listado de artistas completo</post>
        /// <returns>Listado de artistas completo</returns>
        public static List<ClsArtista>? ListadoArtistasBL()
        {
            List<ClsArtista>? artistas = ClsListadosDAL.ListadoArtistasDAL();
            if (DateTime.Now.Hour < 7)
            {
                artistas = null;
            }
            return artistas;
        }

        /// <summary>
        /// Devuelve un listado de canciones asociados al ID del artista
        /// </summary>
        /// <pre>El ID del artista debe existir en la lista de artistas</pre>
        /// <post>Debido a que es una BD falsa, siempre devolvera un listado de canciones de un artista</post>
        /// <param name="idArtista">ID del artista en cuestion</param>
        /// <returns>Listado de canciones de un artista</returns>
        public static List<ClsCancion> ListadoCancionesBL(int idArtista)
        {
            List<ClsCancion> canciones = ClsListadosDAL.ListadoCancionesDAL(idArtista);
            return canciones;
        }

        /// <summary>
        /// Devuelve la cantidad de canciones que tiene un artista
        /// </summary>
        /// <pre>El ID del artista debe existir en la lista de artistas</pre>
        /// <post>Debido a que el listado de canciones trata de una BD falsa, siempre devolvera un numero mayor o igual que 0</post>
        /// <param name="idArtista">ID del artista en cuestion</param>
        /// <returns>Numero de canciones que tiene un artista</returns>
        public static int CantidadCancionesArtistaBL(int idArtista)
        {
            int cantidadCanciones = ClsListadosDAL.CantidadCancionesArtistaDAL(idArtista);
            return cantidadCanciones;
        }
    }
}
