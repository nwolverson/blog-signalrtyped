using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SRHubsTT.StrongAllClientsProxy;

namespace SignalR.Hubs
{
    /// <summary>
    /// Hub & hub methods will generate an interface client site via Hubs.tt
    /// </summary>
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            AllClients.AddNewMessageToPage(name, message);
        }

        #region StronglyTypedSignalr - strong typed clients from https://github.com/devshorts/StronglyTypedSignalr

        private IChatHubClient AllClients
        {
            get { return (Clients.All as ClientProxy).AsStrongHub<IChatHubClient>(); }
        }

        private IChatHubClient CurrentClient
        {
            get
            {
                return (Clients.Client(Context.ConnectionId) as ConnectionIdProxy).AsStrongHub<IChatHubClient>();
            }
        }

        #endregion
    }

    /// <summary>
    /// Will generate an interface client-side via Hubs.tt
    /// </summary>
    public interface IChatHubClient
    {
        void AddNewMessageToPage(string name, string message);
    }

}