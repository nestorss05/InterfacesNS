using Ejercicio5Ent;
using Ejercicio5DAL;
using System.Collections.ObjectModel;

namespace Ejercicio5UI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            PersonaView.ItemsSource = Ejercicio5DAL.clsListados.getListadoCompletoPersonas();
        }
    }

}
