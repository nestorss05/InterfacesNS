using BibliotecaClases;
using System.Windows;

namespace AplicacionWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ClsPersona per = new ClsPersona();
            per.setNombre(textBox.Text);
            MessageBox.Show("Hola " + per.getNombre(), "", MessageBoxButton.OK, MessageBoxImage.None);
        }

    }
}