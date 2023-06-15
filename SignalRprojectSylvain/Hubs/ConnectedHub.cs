using Microsoft.AspNetCore.SignalR;


namespace SignalRprojectSylvain.Hubs
{
    public class ConnectedHub: Hub
    {

        //Ctrl + K, Ctrl + D

        public async Task SendMessage(string user, string message)
        {


            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

    }
}
