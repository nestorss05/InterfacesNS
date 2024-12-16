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
        private ClsCasilla casillaSeleccionada;
        private int tiradas;
        private int limiteBombas;
        public ObservableCollection<ClsCasilla> tablero;
        #endregion

        #region Propiedades
        public ClsCasilla CasillaSeleccionada 
        {
            get { return casillaSeleccionada; }
            set { casillaSeleccionada = value; } // TODO ??
        }
        public int Tiradas 
        { 
            get { return tiradas; }
        }
        public int LimiteBombas
        { 
            get { return limiteBombas; }
        }
        public ObservableCollection<ClsCasilla> Tablero 
        { 
            get { return tablero; } 
        }
        #endregion

        #region Constructor
        public PantallaVM()
        {
            try
            {
                limiteBombas = ClsJuegoBL.GetLimiteBombas(nivel);
                tiradas = ClsJuegoBL.GetTiradasMaximas(nivel);
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
