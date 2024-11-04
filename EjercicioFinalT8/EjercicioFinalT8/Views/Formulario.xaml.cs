namespace EjercicioFinalT8.Views;

public partial class Formulario : ContentPage
{
	public Formulario()
	{
		InitializeComponent();
	}

    private async void boton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Informacion", "Los datos han sido guardados", "Aceptar");
    }
}