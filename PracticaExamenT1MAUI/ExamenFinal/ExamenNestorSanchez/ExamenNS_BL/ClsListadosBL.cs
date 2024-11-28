using ExamenNS_DAL;
using ExamenNS_ENT;

namespace ExamenNS_BL
{
    public class ClsListadosBL
    {
        /// <summary>
        /// Metodo que devuelve un listado completo de misiones
        /// </summary>
        /// <pre>Ninguna</pre>
        /// <post>Siempre devuelve un listado completo de misiones</post>
        /// <returns>Listado completo de misiones</returns>
        public static List<ClsMision> ListadoMisionesBL()
        {
            List<ClsMision>misiones = ClsListadosDAL.ListadoMisionesDAL();
            return misiones;
        }

        /// <summary>
        /// Metodo que devuelve un listado de candidatos por ID de mision con restricciones aplicadas
        /// </summary>
        /// <pre>ID de mision existente en el listado de misiones</pre>
        /// <post>Puede devolver una lista vacia en caso de que el ID de mision no exista en el listado de misiones. De lo contrario, devuelve un listado de candidatos con las restricciones aplicadas</post>
        /// <param name="idMision">ID de la mision</param>
        /// <returns>Listado de candidatos por ID de mision con restricciones aplicadas</returns>
        public static List<ClsCandidato> ListadoCandidatosPorMisionBL(ClsMision mision)
        {

            // Listado original de candidatos
            List<ClsCandidato> candidatosOriginal = ClsListadosDAL.ListadoCandidatosDAL();

            // Listado a la que se le iran metiendo los candidatos de la lista original que les correspondan los requisitos de una mision
            List<ClsCandidato> candidatos = new List<ClsCandidato>();
            
            // Recorre el listado de candidatos original y, a medida de las consideraciones de Tony Soprano, asigna una mision u otra a cada candidato
            foreach (ClsCandidato c in candidatosOriginal)
            {
                if (mision.Dificultad <= 2 && c.Pais == "USA")
                {
                    candidatos.Add(c);
                }
                else if (mision.Dificultad == 3 && c.Pais == "USA" && c.Edad >= 40)
                {
                    candidatos.Add(c);
                } 
                else if (mision.Dificultad == 4 && c.Pais == "Italia" && c.Edad < 45) {
                    candidatos.Add(c);
                }
                else if (mision.Dificultad == 5 && c.Pais == "Italia" && c.Edad >= 45 && c.Edad < 55)
                {
                    candidatos.Add(c);
                }
            }

            // Se devolvera la lista modificada de candidatos
            return candidatos;
        }

        /// <summary>
        /// Metodo que devuelve una mision escogida mediante un ID de mision
        /// </summary>
        /// <pre>ID de mision existente en el listado de misiones</pre>
        /// <post>La mision puede ser nula en caso de no encontrarla. De lo contrario, devolvera una mision</post>
        /// <param name="idMision">ID de la mision a buscar</param>
        /// <returns>Mision a buscar</returns>
        public static ClsMision MisionEscogidaBL(int idMision)
        {
            ClsMision ms = ClsListadosDAL.MisionEscogidaDAL(idMision);
            return ms;
        }

        /// <summary>
        /// Metodo que devuelve un candidato escogido mediante un ID de candidato
        /// </summary>
        /// <pre>ID de candidato existente en el listado de candidatos por mision escogida</pre>
        /// <post>Puede devolver un ClsCandidato vacio en caso de que el ID del candidato no exista en el listado de candidatos. De lo contrario, devuelve el candidato escogido mediante el ID seleccionado</post>
        /// <param name="idCandidato">ID del candidato</param>
        /// <returns>Candidato escogido por ID de mision</returns>
        public static ClsCandidato CandidatoEscogidoBL(int idCandidato)
        {
            ClsCandidato candidato = ClsListadosDAL.CandidatoEscogidoDAL(idCandidato);
            return candidato;
        }
    }
}
