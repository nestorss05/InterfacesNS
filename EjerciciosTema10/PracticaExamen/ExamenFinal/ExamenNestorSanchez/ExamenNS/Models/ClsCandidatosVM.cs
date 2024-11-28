using ExamenNS_BL;
using ExamenNS_ENT;

namespace ExamenNS.Models
{
    public class ClsCandidatosVM: ClsListadosVM
    {
        #region Atributos
        private ClsCandidato candidatoEscogido;
        #endregion

        #region Propiedades
        public ClsCandidato CandidatoEscogido { get { return candidatoEscogido; } }
        #endregion

        #region Constructores
        public ClsCandidatosVM(int id)
        {
            candidatoEscogido = ClsListadosBL.CandidatoEscogidoBL(id);
        }
        #endregion

    }
}
