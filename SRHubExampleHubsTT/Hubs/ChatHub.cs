using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR.Hubs
{
    /// <summary>
    /// Hub & hub methods will generate an interface client site via Hubs.tt
    /// </summary>
    public class ChatHub : Hub<IChatHubClient>
    {
        public void Send(string name, string message)
        {
            Clients.All.AddNewMessageToPage(name, message);
        }
    }

    /// <summary>
    /// Will generate an interface client-side via Hubs.tt
    /// </summary>
    public interface IChatHubClient
    {
        void AddNewMessageToPage(string name, string message);
    }

}