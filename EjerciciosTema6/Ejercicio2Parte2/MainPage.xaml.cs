namespace Ejercicio2Parte2
{
    public partial class MainPage : ContentPage
    {
        
        /// <summary>
        /// Booleana que indica si hay mensaje o no
        /// </summary>
        private bool hayMensaje = false;

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Codigo que se ejecuta al hacer clic en el CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (!hayMensaje)
            {
                mensaje();
                
            } 
            else
            {
                hayMensaje = false;
            }
            
        }

        /// <summary>
        /// Funcion que se encarga de mostrar el mensaje y establecer hayMensaje a true
        /// </summary>
        private async void mensaje()
        {
            await DisplayAlert("Referencia", "YEAH, TOAST!", "Aceptar");
            hayMensaje = true;
        }

    }

}
