using ExamenNS_ENT;

namespace ExamenNS_DAL
{
    public class ClsListadosDAL
    {
        /// <summary>
        /// Metodo que devuelve un listado completo de misiones
        /// </summary>
        /// <pre>Ninguna</pre>
        /// <post>Siempre devuelve un listado completo de misiones</post>
        /// <returns>Listado completo de misiones</returns>
        public static List<ClsMision>ListadoMisionesDAL()
        {
            return new List<ClsMision>() 
            { 
                new ClsMision(1, "Recoger impuestos en el restaurante", 1),
                new ClsMision(2, "Hacer una oferta que no puedan rechazar al sindicato de basura", 2),
                new ClsMision(3, "Supervisar obras en New Jersey", 3),
                new ClsMision(4, "Convencer a Concejal de urbanismo para conseguir favores", 4),
                new ClsMision(5, "Encargarse del concejal de urbanismo que no se dejo convencer", 5),
                new ClsMision(6, "Llevar la contabilidad del Bada Bing", 1)
            };
        }

        /// <summary>
        /// Metodo que devuelve un listado de candidatos
        /// </summary>
        /// <pre>Ninguna</pre>
        /// <post>Siempre devuelve un listado completo de candidatos</post>
        /// <returns>Listado de candidatos</returns>
        public static List<ClsCandidato>ListadoCandidatosDAL()
        {
            return new List<ClsCandidato>() 
            { 
                new ClsCandidato(1, "Vito", "Gordon", 63, "USA", "Pizza Street, 1232", 54567686, 2500),
                new ClsCandidato(2, "Christopher", "Moltisanti", 24, "USA", "St Monti Av", 54567686, 1500),
                new ClsCandidato(3, "Braulia", "Galliani", 26, "USA", "Brooklyn Av", 54567686, 1500),
                new ClsCandidato(4, "Paulie", "Gualtieri", 56, "USA", "Soprano Street, 5", 54567686, 2000),
                new ClsCandidato(5, "Estas", "Caputo", 51, "Italia", "Via Bonna Sera, 14", 54567686, 20000),
                new ClsCandidato(6, "Toco", "L'Acordeone", 40, "Italia", "Via Musica, 20", 54567686, 14000),
                new ClsCandidato(7, "Luigi", "Pepperoni", 25, "Italia", "Piaza Roma, 3", 54567686, 16000),
                new ClsCandidato(8, "Silvio", "Dante", 48, "USA", "Town Street, 56", 54567686, 2000)
            };
        }

        /// <summary>
        /// Metodo que devuelve una mision escogida mediante un ID de mision
        /// </summary>
        /// <pre>ID de mision existente en el listado de misiones</pre>
        /// <post>La mision puede ser nula en caso de no encontrarla. De lo contrario, devolvera una mision</post>
        /// <param name="idMision">ID de la mision a buscar</param>
        /// <returns>Mision a buscar</returns>
        public static ClsMision MisionEscogidaDAL(int idMision)
        {
            List<ClsMision> misiones = ListadoMisionesDAL();
            ClsMision mision = (ClsMision)misiones.Where(ms => ms.IdMision == idMision).First();
            return mision;
        }

        /// <summary>
        /// Metodo que devuelve un candidato escogido mediante un ID de candidato
        /// </summary>
        /// <pre>ID de candidato existente en el listado de candidatos por mision escogida</pre>
        /// <post>Puede devolver un ClsCandidato vacio en caso de que el ID del candidato no exista en el listado de candidatos. De lo contrario, devuelve el candidato escogido mediante el ID seleccionado</post>
        /// <param name="idCandidato">ID del candidato</param>
        /// <returns>Candidato escogido por ID de mision</returns>
        public static ClsCandidato CandidatoEscogidoDAL(int idCandidato)
        {

            // Lista de candidatos a analizar
            List<ClsCandidato> candidatos = ListadoCandidatosDAL();

            // En candidatoBuscado, se buscara el candidato mediante el id de candidato traido como parametro
            ClsCandidato candidatoBuscado = (ClsCandidato)candidatos.Where(can => can.IdCandidato == idCandidato).First();
            
            // El metodo retornara candidatoBuscado
            return candidatoBuscado;
        }

    }
}
