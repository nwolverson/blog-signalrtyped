using Castle.DynamicProxy;
using Microsoft.AspNet.SignalR.Hubs;

namespace SRHubsTT.StrongAllClientsProxy
{
    public static class HubExtensions
    {
        private static readonly ProxyGenerator Generator = new ProxyGenerator();

        public static T AsStrongHub<T>(this IClientProxy source)
        {
            return (T)Generator.CreateInterfaceProxyWithoutTarget(typeof(T), new StrongClientProxy(source));
        }
    }
}