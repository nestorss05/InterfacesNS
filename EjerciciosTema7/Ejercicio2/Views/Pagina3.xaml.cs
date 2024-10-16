namespace Ejercicio2.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}

    private async void boton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}