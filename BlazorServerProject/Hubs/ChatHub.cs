using Microsoft.AspNetCore.SignalR;

namespace BlazorServerProject.Hubs;

public class ChatHub : Hub
{
    public Task SendMesage(string user, string message)
    {
        return Clients.All.SendAsync(method:"ReceiveMessage",user, message);
    }
}