using NoMinesUI.Models;
using System.Collections.ObjectModel;

namespace NoMinesBL
{
    public class ClsJuegoBL
    {
        /// <summary>
        /// Genera una tabla de casillas
        /// Pre: el nivel debe ser mayor o igual que 1
        /// Post: el metodo siempre devuelve un ObservableCollection de casillas
        /// </summary>
        /// <param name="nivel">Cantidad de casillas en el tablero</param>
        /// <returns>Devuelve una tabla de casillas</returns>
        public static ObservableCollection<ClsCasilla> getCasillas(int nivel)
        {
            ObservableCollection<ClsCasilla> tablero = new ObservableCollection<ClsCasilla>();
            ClsCasilla casilla;
            int nCasillas = nivel * nivel;
            for (int i = 0; i < nCasillas; i++) 
            {
                casilla = new ClsCasilla();
                tablero.Add(casilla);
            }
            return tablero;
        }

        /// <summary>
        /// Metodo que genera el limite de bombas a base del nivel
        /// </summary>
        /// <param name="nivel"></param>
        /// <returns></returns>
        public static int GetLimiteBombas(int nivel)
        {

        }

        /// <summary>
        /// Metodo que genera el nº de tiradas maximas a base del nivel
        /// </summary>
        /// <param name="nivel"></param>
        /// <returns></returns>
        public static int GetTiradasMaximas(int nivel)
        {

        }

    }
}
