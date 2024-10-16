using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace HelloWorldUWP
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            textBlock.Visibility = Visibility.Collapsed;
            button.CornerRadius = new CornerRadius(32);
        }

        /// <summary>
        /// <description>This method changes a textbox to "HelloWorld"</description>
        /// <precondition>None</precondition>
        /// <postcondition>None</postcondition>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog contentDialog;
            contentDialog = new ContentDialog() {
                Title = "Hello World",
                Content = "Hello World",
                CloseButtonText = "OK"
            };

            await contentDialog.ShowAsync();
            textBlock.Text = "Hello World (2)";            
            textBlock.Visibility = Visibility.Visible;
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
