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
            _connection.On<string>("MessageRecieved", (message) =>
            {
                chatMessages.Text += $"{Environment.NewLine}{message}";
            });

            Task.Run(() =>
            {
                Dispatcher.Dispatch(async () =>
                await _connection.StartAsync());
            });
        }

        private async void Send(object sender, EventArgs e)
        {
            await _connection.InvokeCoreAsync("SendMessage", args: new[] 
            { myChatMessage.Text });

            myChatMessage.Text = String.Empty;
        }

    }

}
