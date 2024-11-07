using Ejercicio5.Models;
using Ejercicio5.ViewModels;

namespace Ejercicio5.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {
            var viewCell = sender as ViewCell;
            ClsPersona persona = viewCell?.BindingContext as ClsPersona;
            
            if (persona != null)
            {
                await Navigation.PushAsync(new Detalles(persona));
            }
        }
    }

}
