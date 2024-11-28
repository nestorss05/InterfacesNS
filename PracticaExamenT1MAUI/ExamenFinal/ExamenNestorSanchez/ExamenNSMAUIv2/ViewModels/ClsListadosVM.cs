using Ejercicio1.ViewModels.Utilidades;
using ExamenNS_BL;
using ExamenNS_ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenNSMAUIv2.ViewModels
{
    [QueryProperty(nameof(CandidatoEscogido), "CandidatoEscogido")]
    public class ClsListadosVM: INotifyPropertyChanged
    {
        #region Atributos
        private List<ClsMision> misiones;
        private ObservableCollection<ClsCandidato> candidatos;
        private ClsMision misionEscogida;
        private ClsCandidato candidatoEscogido;
        private DelegateCommand detailsCommand;
        #endregion Atributos

        #region Propiedades
        public List<ClsMision> Misiones
        { 
            get { return misiones; } 
        }
        public ObservableCollection<ClsCandidato> Candidatos 
        { 
            get { return candidatos; } 
        }
        public ClsMision MisionEscogida 
        { 
            get { return misionEscogida; } 
            set 
            { 
                misionEscogida = value; 
                NotifyPropertyChanged("MisionEscogida");
                añadirCandidatos();                
            }
        }
        public ClsCandidato CandidatoEscogido
        {
            get { return candidatoEscogido; }
            set
            {
                candidatoEscogido = value;
                NotifyPropertyChanged("CandidatoEscogido");
                detailsCommand.RaiseCanExecuteChanged();
            }
        }
        public DelegateCommand DetailsCommand 
        { 
            get { return detailsCommand; } 
        }
        #endregion

        #region Constructores
        public ClsListadosVM()
        {
            misiones = ClsListadosBL.ListadoMisionesBL();
            misionEscogida = misiones[0];
            detailsCommand = new DelegateCommand(DetailsCommand_Execute, DetailsCommand_CanExecute);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que añade los contactos de una List a la ObservableCollection, debido a que no se pueden pasar los datos de una List directamente a una ObservableCollection
        /// Pre: Ninguna
        /// Post: Ninguna
        /// </summary>
        private void añadirCandidatos()
        {
            List<ClsCandidato> candidatosList = ClsListadosBL.ListadoCandidatosPorMisionBL(misionEscogida);
            if (candidatos is not null)
            {
                candidatos.Clear();
            } else
            {
                candidatos = new ObservableCollection<ClsCandidato>();
            }
            foreach (ClsCandidato c in candidatosList) 
            { 
                candidatos.Add(c);
            }
        }

        /// <summary>
        /// Metodo que dirige al usuario a la pantalla de detalles
        /// Pre: ninguna
        /// Post: ninguna
        /// </summary>
        private async void DetailsCommand_Execute()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "CandidatoEscogido", candidatoEscogido }
            };
            await Shell.Current.GoToAsync("//Detalles", navigationParameter);
        }

        /// <summary>
        /// Metodo que devuelve si se puede acceder al boton de detalles
        /// Pre: ninguna
        /// Post: siempre devuelve una booleana que indica true/false
        /// </summary>
        /// <returns>Si se activa o no el boton de detalles</returns>
        private bool DetailsCommand_CanExecute()
        {
            bool res = false;
            if (candidatoEscogido is not null)
            {
                res = true;
            }
            return res;
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
