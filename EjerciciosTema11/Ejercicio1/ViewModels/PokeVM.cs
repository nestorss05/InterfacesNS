using Ejercicio1.ViewModels.Utilidades;
using Ejercicio1DAL;
using Ejercicio1ENT;
using MessagePack.Formatters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.ViewModels
{
    public class PokeVM: INotifyPropertyChanged
    {

        #region Atributos
        private ObservableCollection<ClsPokemon>? listadoPokemons;
        private DelegateCommand executeCommand;
        private int offset = 0;
        private const int limit = 20;
        #endregion

        #region Propiedades
        public ObservableCollection<ClsPokemon>? ListadoPokemons
        {
            get { return listadoPokemons; }
            set 
            { 
                listadoPokemons = value;
                NotifyPropertyChanged("ListadoPokemons");
            }
        }
        public DelegateCommand ExecuteCommand
        {
            get
            {
                return executeCommand;
            }
        }
        #endregion

        #region Constructores
        public PokeVM()
        {
            executeCommand = new DelegateCommand(ExecuteCommand_Executed);
        }
        #endregion

        #region Metodos
        private async void ExecuteCommand_Executed()
        {
            List<ClsPokemon> nuevosPokemons = await ClsPokemonDAL.GetPokemonsDAL(offset, limit);
            if (listadoPokemons == null)
            {
                listadoPokemons = new ObservableCollection<ClsPokemon>();
            }
            else
            {
                listadoPokemons.Clear();
            }

            foreach (ClsPokemon pokemon in nuevosPokemons)
            {
                listadoPokemons.Add(pokemon);
            }
            offset += 20;
            NotifyPropertyChanged("ListadoPokemons");
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
