using EjercicioArtistasENT;

namespace EjercicioArtistasDAL
{
    public class ClsListadosDAL
    {
        /// <summary>
        /// Devuelve un listado de artistas completo
        /// </summary>
        /// <pre>Nada</pre>
        /// <post>Siempre devuelve un listado de artistas completo</post>
        /// <returns>Listado de artistas completo</returns>
        public static List<ClsArtista> ListadoArtistasDAL()
        {
            return new List<ClsArtista>()
            {
                new ClsArtista(1, "Miguel", "Borrego", "Urban Z Music", "48596840F", new DateTime(2006, 02, 11), "Miami"),
                new ClsArtista(2, "Aurelio", "Boris", "Señor Terror", "24567873T", new DateTime(1994, 09, 22), "Benacazon"),
                new ClsArtista(3, "Carlos", "Salinas", "Papote Malote", "75343657B", new DateTime(1999, 11, 29), "Medellin"),
                new ClsArtista(4, "Carlitos", "LaHiena", "MC Revolver", "63456354R", new DateTime(2003, 08, 19), "Sevilla"),
                new ClsArtista(5, "Pablo", "Dominguez", "Su_Morenito_19", "54377456E", new DateTime(2005, 05, 26), "Los Alcores"),
                new ClsArtista(6, "Lucas", "Salas", "Lucas Skywalker", "75554772B", new DateTime(2006, 12, 01), "DLC de Torreblanca")
            };
        }

        /// <summary>
        /// Devuelve un listado de canciones asociados al ID del artista
        /// </summary>
        /// <pre>El ID del artista debe existir en la lista de artistas</pre>
        /// <post>Debido a que es una BD falsa, siempre devolvera un listado de canciones de un artista</post>
        /// <param name="idArtista">ID del artista en cuestion</param>
        /// <returns>Listado de canciones de un artista</returns>
        public static List<ClsCancion> ListadoCancionesDAL(int idArtista)
        {
            List<ClsCancion> listaOriginal = new List<ClsCancion>() { 
                new ClsCancion(1, 1, "Soy puter", "3:11", "Trap", 2023),
                new ClsCancion(2, 3, "Soy reggaeton", "3:21", "Reggaeton", 2023),
                new ClsCancion(3, 5, "Soy cani", "3:29", "Falso Pop", 2022),
                new ClsCancion(4, 3, "Colosio Colosal", "3:09", "Blues", 2014),
                new ClsCancion(5, 2, "Soy gotico", "2:20", "Gotico", 2012),
                new ClsCancion(6, 6, "Soy friki", "4:07", "Pop", 2024),
                new ClsCancion(7, 4, "Bandolero", "3:25", "Trap", 2022),
                new ClsCancion(8, 1, "Rap de Anuel", "2:46", "Rap", 2023),
                new ClsCancion(9, 2, "Gotica Q-Loona", "3:11", "Trap", 2019),
                new ClsCancion(10, 5, "Nadie conoce al Betis", "1:53", "Antibetis", 2017),
                new ClsCancion(11, 6, "Sociedad", "2:45", "Trap", 2023),
                new ClsCancion(12, 4, "Bandolero Remix", "2:58", "Reggaeton", 2024),
                new ClsCancion(13, 3, "Solidaridad", "2:02", "Pop", 2019),
                new ClsCancion(14, 6, "Nestle caca", "3:24", "Trap", 2023)
            };
            List<ClsCancion> listaFinal = new List<ClsCancion>();
            foreach (ClsCancion c in listaOriginal) {
                if (c.IdArtista == idArtista) 
                {
                    listaFinal.Add(c); 
                }
            }
            return listaFinal;
        }

        /// <summary>
        /// Devuelve la cantidad de canciones que tiene un artista
        /// </summary>
        /// <pre>El ID del artista debe existir en la lista de artistas</pre>
        /// <post>Debido a que el listado de canciones trata de una BD falsa, siempre devolvera un numero mayor o igual que 0</post>
        /// <param name="idArtista">ID del artista en cuestion</param>
        /// <returns>Numero de canciones que tiene un artista</returns>
        public static int CantidadCancionesArtistaDAL(int idArtista)
        {
            List<ClsCancion> canciones = ListadoCancionesDAL(idArtista);
            int cantidadCanciones = canciones.Count;
            return cantidadCanciones;
        }
    }
}
