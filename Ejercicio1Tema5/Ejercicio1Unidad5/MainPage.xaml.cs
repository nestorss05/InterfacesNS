using BibliotecaClases;

namespace Ejercicio1Unidad5
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            mostrarPersona();

        }

        private async void mostrarPersona()
        {
            String nombre = entry.Text;
            String apellidos = await DisplayPromptAsync("Apellidos", "Inserte sus apellidos");
            
            ClsPersona per = new ClsPersona(nombre, apellidos);

            label.Text = "Hola " + per.Nombre + " " + per.Apellidos;

            SemanticScreenReader.Announce(label.Text);
        }
    }

}
