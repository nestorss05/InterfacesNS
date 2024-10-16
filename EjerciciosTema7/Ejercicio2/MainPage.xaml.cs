using Ejercicio2.Views;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void boton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaTabbed());
        }
    }

}
