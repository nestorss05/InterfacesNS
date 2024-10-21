using Ejercicio1.Views;

namespace Ejercicio1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaTabbed();
        }
    }
}
