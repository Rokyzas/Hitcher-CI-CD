using Microsoft.AspNetCore.SignalR;

namespace SignalRChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string id)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, id);
        }
    }
}
