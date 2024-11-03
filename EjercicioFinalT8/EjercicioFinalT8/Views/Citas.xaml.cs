namespace EjercicioFinalT8.Views;

public partial class Citas : ContentPage
{
	public Citas()
	{
		InitializeComponent();
        fecha.Text = DateTime.Now.ToShortDateString();
	}

    private async void boton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Tabs());
    }

}