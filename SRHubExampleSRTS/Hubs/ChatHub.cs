using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.AddNewMessageToPage(name, message);
        }
    }

    public interface IChatHubClient
    {
        void AddNewMessageToPage(string name, string message);
    }

}