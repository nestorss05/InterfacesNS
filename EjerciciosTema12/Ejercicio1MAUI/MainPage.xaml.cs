using Microsoft.AspNetCore.SignalR.Client;

namespace Ejercicio1MAUI
{
    public partial class MainPage : ContentPage
    {
        private readonly HubConnection _connection;
        public MainPage()
        {
            InitializeComponent();
            _connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:7237")
                .Build();
            _connection.On<string>("MessageRecieved");
            // https://www.youtube.com/watch?v=pDr0Hx67guk
            // 11:46
        }

        private void Send(object sender, EventArgs e)
        {

        }

    }

}
