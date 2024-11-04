using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.ViewModels
{
    public class MainPageVM : INotifyPropertyChanged
    {



        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertychanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
