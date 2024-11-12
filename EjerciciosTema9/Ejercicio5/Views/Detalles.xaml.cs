namespace Ejercicio5.Views;

public partial class Detalles : ContentPage
{
	public Detalles(Models.ClsPersona? persona)
	{
		InitializeComponent();
        BindingContext = persona;
    }
}