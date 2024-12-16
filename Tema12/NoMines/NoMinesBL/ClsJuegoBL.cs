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
            // TODO editar la wea
            ObservableCollection<ClsCasilla> tablero = new ObservableCollection<ClsCasilla>();
            ClsCasilla casilla;
            int nCasillas = 0;

            switch (nivel)
            {
                case 1:
                    nCasillas = 9;
                    break;

                case 2:
                    nCasillas = 16;
                    break;

                case 3:
                    nCasillas = 25;
                    break;

            }

            for (int i = 0; i < nCasillas; i++) 
            {
                casilla = new ClsCasilla();
                // TODO como uso el limite de bombas
                // Bombas por nivel 1 al 3: 3 6 13
                // TODO meter aqui array de casillas con bombita :)
                // (y si su longitud es el maximo del tablero, ya no seran bombitas las nuevas)
                tablero.Add(casilla);
            }

            return tablero;
        }

        /// <summary>
        /// Metodo que genera el limite de bombas a base del nivel
        /// Pre: El nivel debe ser mayor o igual que 1
        /// Post: El metodo siempre devuelve un numero entero menor que el nº de casillas del tablero
        /// </summary>
        /// <param name="nivel">Nivel del juego</param>
        /// <returns>Nº de bombas en el tablero</returns>
        public static int GetLimiteBombas(int nivel)
        {
            int limiteBombas = 0;
            switch (nivel)
            {
                case 1:
                    limiteBombas = 2;
                    break;

                case 2:
                    limiteBombas = 4;
                    break;

                case 3:
                    limiteBombas = 6;
                    break;

            }

            return limiteBombas;
        }

        /// <summary>
        /// Metodo que genera el nº de tiradas maximas a base del nivel
        /// Pre: El nivel debe ser mayor o igual que 1
        /// Post: El metodo siempre devuelve un numero entero menor que el nº de casillas del tablero
        /// </summary>
        /// <param name="nivel">Nivel del juego</param>
        /// <returns>Nº de tiradas maximas del juego</returns>
        public static int GetTiradasMaximas(int nivel)
        {
            int tiradas = 0;
            switch (nivel)
            {
                case 1:
                    tiradas = 6;
                    break;

                case 2:
                    tiradas = 9;
                    break;

                case 3:
                    tiradas = 12;
                    break;

            }

            return tiradas;
        }

    }
}
