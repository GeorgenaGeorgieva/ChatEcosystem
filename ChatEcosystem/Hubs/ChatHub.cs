using ChatEcosystem.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatEcosystem.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("receiveMessage", message);
    }
}
