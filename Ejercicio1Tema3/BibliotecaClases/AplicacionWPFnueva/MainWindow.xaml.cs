using BibliotecaClases;
using System.Windows;

namespace AplicacionWPFnueva
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento asociado al boton encontrado en la pantalla de relleno de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            ClsPersona per = new ClsPersona();
            if (textBox.Text != "")
            {
                per.Nombre = textBox.Text;
            }
            if (textBox2.Text != "")
            {
                per.Apellido = textBox2.Text;
            }
            if (textBox3.Text != "")
            {
                per.FechaNac = DateTime.Parse(textBox3.Text);
            }
            MessageBox.Show($"Hola {per.Nombre} {per.Apellido}. Tienes {per.Edad} anios.", "", MessageBoxButton.OK);
        }

    }
}