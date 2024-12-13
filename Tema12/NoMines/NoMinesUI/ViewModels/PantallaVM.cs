using NoMinesBL;
using NoMinesUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMinesUI.ViewModels
{
    public class PantallaVM
    {

        #region Atributos
        private int nivel = 4;
        private int maxJugadas;
        private int aciertos;
        private int fallos;
        #endregion

        #region Propiedades
        public ClsCasilla CasillaSeleccionada { get; set; }
        public int Tiradas { get; }
        public int LimiteBombas { get; }
        public ObservableCollection<ClsCasilla> Tablero { get; }
        #endregion

        #region Constructor
        public PantallaVM()
        {
            try
            {
                ClsJuegoBL.getCasillas(nivel);

            }
            catch (Exception ex) 
            {
                ex.GetBaseException();
            }
            
        }
        #endregion

        #region Metodos

        #endregion

    }
}
