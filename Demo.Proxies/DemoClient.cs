using System.ServiceModel;
using System.ServiceModel.Channels;
using Demo.Contracts;

namespace Demo.Proxies
{
    public class DemoClient : ClientBase<IDemoService>, IDemoService
    {
        public static string Version { get; set; }

        public DemoClient()
        {
            // spin the operation scope
            // note: if not doing this at first then 
            // the OperationContext.Current will be NULL
            var operationScope = new OperationContextScope(InnerChannel);

            // inject version value into soap message header
            if (!string.IsNullOrWhiteSpace(Version))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(
                    MessageHeader.CreateHeader("VER_NR", "http://pingo/version", Version));
            }
        }

        public void DoSomething()
        {
            Channel.DoSomething();
        }
    }
}
