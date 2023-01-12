using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace ViesCheckSpain
{


    public class MessageInspectorBehavior : IClientMessageInspector, IEndpointBehavior
    {
      

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            var buffer = reply.CreateBufferedCopy(int.MaxValue);
            var receivedMessage = buffer.CreateMessage();
            Console.WriteLine(receivedMessage);
            reply = buffer.CreateMessage();
        }

        public object BeforeSendRequest(ref Message request,
            System.ServiceModel.IClientChannel channel)
        {
            Console.WriteLine(request.ToString());
            return null;
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        { }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.ClientMessageInspectors.Add(this);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        { }

        public void Validate(ServiceEndpoint endpoint)
        { }
    }


}
