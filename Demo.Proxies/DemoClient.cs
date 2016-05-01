using System.ServiceModel;
using Demo.Contracts;

namespace Demo.Proxies
{
    public class DemoClient : ClientBase<IDemoService>, IDemoService
    {
        public void DoSomething()
        {
            Channel.DoSomething();
        }
    }
}
