namespace EjercicioFinalT8.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private async void boton_Clicked(object sender, EventArgs e)
    {
        if (usuario.Text is not null && password.Text != null)
        {
            await Navigation.PushAsync(new Citas());
        } else
        {
            await DisplayAlert("Error", "El usuario y/o la contraseña estan vacios", "Aceptar");
        }
        
    }

}
