namespace Ejercicio1Unidad6
{
    public partial class MainPage : ContentPage
    {
             
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Booleana que indica si el tercer boton existe o no
        /// </summary>
        private bool exists = false;

        /// <summary>
        /// Codigo que se ejecuta al hacer clic en el boton 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton2_Clicked(object sender, EventArgs e)
        {

            if (!exists)
            {
                // Inicializa el boton
                Button boton3 = new Button
                {
                    Text = "Boton3",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    BackgroundColor = Colors.Blue,
                    BorderColor = Colors.Yellow,
                    BorderWidth = 5,
                    MaximumHeightRequest = 70,
                    MaximumWidthRequest = 200,
                    Margin = 5,
                    FontFamily = "Verdana",
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 16,
                };

                // Enlaza el boton
                boton3.Clicked += onButton3Clicked;

                // Muestra el boton por pantalla
                MainLayout.Children.Add(boton3);

                // exists sera true
                exists = true;
            }
            
        }

        /// <summary>
        /// Codigo que se ejecuta al hacer clic en el boton 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onButton3Clicked(object? sender, EventArgs e)
        {
            // Quita el boton por pantalla y cambia el texto del segundo boton
            MainLayout.Children.Remove(boton1);
            boton2.Text = "Crear controles en tiempo de ejecución mola";
        }
    }

}
