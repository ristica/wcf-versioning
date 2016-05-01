using System.ServiceModel;

namespace Demo.Contracts
{
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        void DoSomething();
    }
}
