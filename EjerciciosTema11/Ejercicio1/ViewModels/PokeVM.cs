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
        private List<ClsPokemon>? listadoPokemons;
        private DelegateCommand executeCommand;
        #endregion

        #region Propiedades
        public List<ClsPokemon>? ListadoPokemons
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
            listadoPokemons = await ClsPokemonDAL.GetPokemonsDAL();
            // TODO: UI en MainPage
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
