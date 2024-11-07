using Ejercicio5.Models;

namespace Ejercicio5.Views;

public partial class Detalles : ContentPage
{

	private ClsPersona Persona { get; set; }

	public Detalles(ClsPersona per)
	{
		InitializeComponent();
		Persona = per;
		BindingContext = Persona;
	}
}