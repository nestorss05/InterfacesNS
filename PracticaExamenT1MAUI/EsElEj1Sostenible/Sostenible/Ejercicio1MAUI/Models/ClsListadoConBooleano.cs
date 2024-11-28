using Ejercicio1ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1MAUI.Models
{
    public class ClsListadoConBooleano: ClsPersona
    {

        private bool mayorEdad;

        public bool MayorEdad 
        { 
            get { return mayorEdad; } 
            set { mayorEdad = value; } 
        }

        public ClsListadoConBooleano(ClsPersona per): base()
        {
            base.Nombre = per.Nombre;
            base.Apellidos = per.Apellidos;
            base.FechaNac = per.FechaNac;
            mayorEdad = ComprobarMayoriaEdad();
        }

        /// <summary>
        /// Metodo que comprueba la mayoria de edad de una persona
        /// Pre: nada
        /// Post: siempre devuelve un booleano que indica true o false
        /// </summary>
        /// <returns>Indicador acerca de la mayoria de edad de la persona</returns>
        private bool ComprobarMayoriaEdad()
        {
            bool res = false;
            if (DateTime.Now.Year - base.FechaNac.Year >= 18 && DateTime.Now.Month >= base.FechaNac.Month && DateTime.Now.Day >= base.FechaNac.Day)
            {
                res = true;
            }
            return res;
        }

    }
}
