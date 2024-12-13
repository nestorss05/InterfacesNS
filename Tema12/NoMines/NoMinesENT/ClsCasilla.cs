using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NoMinesUI.Models
{
    public class ClsCasilla: INotifyPropertyChanged
    {
        private bool esMina;
        private bool revelado;
        private string foto;
        public bool EsMina
        { 
            get { return esMina; }
        }
        public bool Revelado
        { 
            get { return revelado; }
            set { revelado = value; NotifyPropertyChanged("Revelado"); escogerFoto(); }
        }
        public string Foto 
        {
            get { return foto; }
        }

        public ClsCasilla() 
        {
            esMina = false;
            revelado = false;
            foto = escogerFoto();
        }

        private string escogerFoto()
        {
            string foto;
            if (revelado)
            {
                // TODO: enlaces de foto normal o bomba
                if (esMina)
                {
                    foto = "bomba.png";
                } else
                {
                    foto = "oro.jpg";
                }
            } else
            {
                foto = "reversa.jpg";
            }
            return foto;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
