using Ejercicio1BL;
using Ejercicio1ENT;
using Ejercicio1MAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1MAUI.ViewModels
{
    public class ClsListadoVM
    {

        private List<ClsPersona> lista;
        private List<ClsListadoConBooleano> listaFinal;
        
        public List<ClsListadoConBooleano> ListaFinal
        {
            get { return listaFinal; }
            set { listaFinal = value; }
        }

        public ClsListadoVM()
        {
            lista = ClsListadoBL.ListadoPersonasBL();
            listaFinal = new List<ClsListadoConBooleano>();
            foreach (ClsPersona per in lista)
            {
                ClsListadoConBooleano perX = new ClsListadoConBooleano(per);
                listaFinal.Add(perX);
            }
        }

    }
}
