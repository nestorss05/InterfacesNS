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
            await Navigation.PushAsync(new Detalles());
        }
    }

}
