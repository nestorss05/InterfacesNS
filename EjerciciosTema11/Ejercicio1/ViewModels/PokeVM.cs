using Ejercicio1.ViewModels.Utilidades;
using Ejercicio1DAL;
using Ejercicio1DTO;
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
        private DelegateCommand backCommand;
        private int offset = -20;
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
        public DelegateCommand BackCommand
        {
            get
            {
                return backCommand;
            }
        }
        #endregion

        #region Constructores
        public PokeVM()
        {
            executeCommand = new DelegateCommand(ExecuteCommand_Executed);
            backCommand = new DelegateCommand(BackCommand_Executed, BackCommand_CanExecute);
            ExecuteCommand_Executed();
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que carga los proximos 20 pokemons de la lista 
        /// Pre: nada
        /// Post: nada
        /// </summary>
        private void ExecuteCommand_Executed()
        {
            offset += 20;
            Busqueda();
        }

        /// <summary>
        /// Metodo que carga los 20 pokemons anteriores de la lista 
        /// Pre: nada
        /// Post: nada
        /// </summary>
        private void BackCommand_Executed()
        {
            offset -= 20;
            Busqueda();
        }

        /// <summary>
        /// Metodo central para cargar los 20 pokemons de la lista
        /// Pre: nada
        /// Post: nada
        /// </summary>
        private async void Busqueda()
        {
            try
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
            }
            catch (Exception ex)
            {

            }
            finally
            {
                NotifyPropertyChanged("ListadoPokemons");
                backCommand.RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// Metodo que activa o desactiva el boton de volver hacia atras
        /// Pre: nada
        /// Post: el metodo siempre devolvera un booleano
        /// </summary>
        /// <returns>offset mayor o igual que 0</returns>
        private bool BackCommand_CanExecute()
        {
            bool res = false;
            if (offset >= 20)
            {
                res = true;
            }
            return res;
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
