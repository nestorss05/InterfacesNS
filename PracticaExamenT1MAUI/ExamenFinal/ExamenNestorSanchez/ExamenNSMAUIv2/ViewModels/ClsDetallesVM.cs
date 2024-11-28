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
    public class ClsDetallesVM: INotifyPropertyChanged
    {

        #region Atributos
        private ClsCandidato candidatoEscogido;
        private DelegateCommand volverCommand;
        #endregion Atributos

        #region Propiedades
        public ClsCandidato CandidatoEscogido
        {
            get { return candidatoEscogido; }
            set
            {
                candidatoEscogido = value;
                NotifyPropertyChanged("CandidatoEscogido");
            }
        }
        public DelegateCommand VolverCommand
        {
            get { return volverCommand; }
        }
        #endregion

        #region Constructores
        public ClsDetallesVM()
        {
            volverCommand = new DelegateCommand(VolverCommand_Execute);
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que vuelve a la pagina principal
        /// Pre: nada
        /// Post: nada
        /// </summary>
        private async void VolverCommand_Execute()
        {
            await Shell.Current.GoToAsync("//MainPage");
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
