using ExamenNS_BL;
using ExamenNS_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenNSMAUIv2.ViewModels
{
    public class ClsListadosVM: INotifyPropertyChanged
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
            misionEscogida = misiones[0];
        }

        public ClsListadosVM(int idMision)
        {
            misiones = ClsListadosBL.ListadoMisionesBL();
            misionEscogida = ClsListadosBL.MisionEscogidaBL(idMision);
            candidatos = ClsListadosBL.ListadoCandidatosPorMisionBL(misionEscogida);
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion

    }
}
