namespace Ejercicio6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            FechaNac.MaximumDate = DateTime.Now;
        }

        private void BotonCrear_Clicked(object sender, EventArgs e)
        {
            Nombre.Text = "";
            Apellidos.Text = "";
            FechaNac.Date = DateTime.Now;
        }

        private void BotonGuardar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Nombre.Text))
            {
                Resultado.Text = "El nombre esta vacio";
                Resultado.TextColor = Colors.Red;
            }
            else if (String.IsNullOrEmpty(Apellidos.Text)) {
                Resultado.Text = "Los apellidos estan vacios";
                Resultado.TextColor = Colors.Red;
            }
            else
            {
                Resultado.Text = "Contacto guardado correctamente";
                Resultado.TextColor = Colors.Green;
            }
            
        }

        private async void BotonEliminar_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Eliminacion de contacto", "¿Estas seguro de que quieres eliminar el contacto?", "Si", "No");
            if (answer)
            {
                Nombre.Text = "";
                Apellidos.Text = "";
                FechaNac.Date = DateTime.Now;
                Resultado.Text = "Contacto eliminado correctamente";
                Resultado.TextColor = Colors.Green;
            }
        }
    }

}
