using ExamenNS_BL;
using ExamenNS_ENT;

namespace ExamenNS.Models
{
    public class ClsListadosVM
    {
        #region Atributos
        private List<ClsMision> misiones;
        private List<ClsCandidato> candidatos;
        private ClsMision misionEscogida;
        #endregion Atributos

        #region Propiedades
        public List<ClsMision> Misiones { get { return misiones; } }
        public List<ClsCandidato> Candidatos { get { return candidatos; } }
        public ClsMision MisionEscogida { get { return misionEscogida; } }
        #endregion

        #region Constructores
        public ClsListadosVM()
        {
            misiones = ClsListadosBL.ListadoMisionesBL();
        }

        public ClsListadosVM(int idMision)
        {
            misiones = ClsListadosBL.ListadoMisionesBL();
            misionEscogida = ClsListadosBL.MisionEscogidaBL(idMision);
            candidatos = ClsListadosBL.ListadoCandidatosPorMisionBL(misionEscogida);
        }
        #endregion

    }
}
