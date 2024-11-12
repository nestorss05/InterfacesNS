using Ejercicio5.Models;

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
            var persona = viewCell?.BindingContext as ClsPersona;
            await Navigation.PushAsync(new Detalles(persona));
        }
    }

}
