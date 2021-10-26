using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using ASPNETWithReactJS;
using ASPNETWithReactJS.Hubs.Clients;

namespace ASPNETWithReactJS.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}
