using Microsoft.AspNetCore.SignalR;
using ProjectEweis.Models;
using ServiceStack;

namespace ProjectEweis.Hubs
{
    public class ChatHub:Hub
    {
        public override Task OnConnectedAsync()
        {
            Groups.AddToGroupAsync(Context.ConnectionId, Context.User.Identity.Name);
            return base.OnConnectedAsync();
        }
        public async Task SendMessage(Message message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }

        public async Task SendToUser(string user, string receiverConnectionId, string message)
        {
            await Clients.Client(receiverConnectionId).SendAsync("ReceiveMessage", user, message);
        }

        public Task SendMessageToGroup(string receiver, string message)
        {
            return Clients.Group(receiver).SendAsync("ReceiveMessage", message);
        }

        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }
    }
}
