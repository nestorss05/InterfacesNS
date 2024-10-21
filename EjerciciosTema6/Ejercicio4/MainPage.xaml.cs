namespace Ejercicio4
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            fecha1.MinimumDate = DateTime.Today;
            fecha2.MinimumDate = fecha1.Date.AddDays(1);
        }

        /// <summary>
        /// Funcion para establecer la fecha minima de la fecha de salida a la fecha escogida de la fecha de entrada, sumada un dia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fecha1_DateSelected(object sender, DateChangedEventArgs e)
        {
            fecha2.MinimumDate = fecha1.Date.AddDays(1);
        }

    }

}
