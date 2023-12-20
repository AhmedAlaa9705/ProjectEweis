using Microsoft.AspNetCore.SignalR;
using ProjectEweis.Models;
using ServiceStack;

namespace ProjectEweis.Hubs
{
    public class ChatHub:Hub
    {
        
        public async Task SendMessage(string user ,string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }

        public async Task SendToUser(string user, string receiverConnectionId, string message)
        {
            await Clients.Client(receiverConnectionId).SendAsync("ReceiveMessage", user, message);
        }
        public  Task GetUser(string userId)
        {
           return Groups.AddToGroupAsync(Context.ConnectionId,userId);
        }

        public Task SendMessageToGroup(string receiver,string sender, string message)
        {
            return Clients.Group(receiver).SendAsync("ReceiveMessage",sender, message);
        }

        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }
    }
}
