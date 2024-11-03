using EjercicioFinalT8.Views;

namespace EjercicioFinalT8
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
