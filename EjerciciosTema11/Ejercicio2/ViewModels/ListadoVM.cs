using Ejercicio2DAL;
using Ejercicio2ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.ViewModels
{
    public class ListadoVM: INotifyPropertyChanged
    {

        #region Atributos
        private ObservableCollection<ClsPersona>? listadoPersonas;
        private bool sinCargar = true;
        #endregion

        #region Properties
        public ObservableCollection<ClsPersona>? ListadoPersonas
        {
            get { return listadoPersonas; }
            set
            {
                listadoPersonas = value;
                NotifyPropertyChanged("ListadoPersonas");
            }
        }
        public bool SinCargar
        {
            get { return sinCargar; }
            set
            {
                sinCargar = value;
                NotifyPropertyChanged("SinCargar");
            }
        }
        #endregion

        #region Constructores
        public ListadoVM()
        {
            CargarLista();
        }
        #endregion

        #region Metodos
        private async void CargarLista()
        {
            List<ClsPersona> personasEncontradas = await ClsListadoDAL.GetListadoDAL();
            if (ListadoPersonas == null)
            {
                ListadoPersonas = new ObservableCollection<ClsPersona>();
            }
            else
            {
                ListadoPersonas.Clear();
            }
            foreach (ClsPersona persona in personasEncontradas)
            {
                ListadoPersonas.Add(persona);
            }
            SinCargar = false;
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
