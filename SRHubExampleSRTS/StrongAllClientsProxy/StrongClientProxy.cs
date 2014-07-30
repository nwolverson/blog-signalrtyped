using Castle.DynamicProxy;
using Microsoft.AspNet.SignalR.Hubs;

namespace SRHubsTT.StrongAllClientsProxy
{
    public class StrongClientProxy : IInterceptor
    {
        public IClientProxy Source { get; set; }

        public StrongClientProxy(IClientProxy source)
        {
            Source = source;
        }

        public void Intercept(IInvocation invocation)
        {
            var methodName = StringUtil.FirstLower(invocation.Method.Name);

            Source.Invoke(methodName, invocation.Arguments);
        }
    }

}