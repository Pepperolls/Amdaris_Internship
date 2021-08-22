using System;

namespace ProxyDemo
{
    public interface IObject
    {
        void Message();
    }

    class ActualObject : IObject
    {
        public void Message()
        {
            Console.WriteLine("This is the actual object.");
        }
    }

    class ProxyObject : IObject
    {
        private ActualObject ActualObject;

        public ProxyObject(ActualObject actualObject)
        {
            ActualObject = actualObject;
        }

        public void Message()
        {
            if (ShouldOccur())
            {
                ActualObject.Message();

                AfterMessage();
            }
        }

        public bool ShouldOccur()
        {
            Console.WriteLine("Proxy - checking if action should occur.");
            return true;
        }

        public void AfterMessage()
        {
            Console.WriteLine("Proxy - executed successfully");
        }
    }

    public class Client
    {
        public void ClientTestingMethod(IObject randomObject)
        {
            randomObject.Message();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            ActualObject actualObject = new ActualObject();
            client.ClientTestingMethod(actualObject);

            ProxyObject proxyObject = new ProxyObject(actualObject);
            client.ClientTestingMethod(proxyObject);
        }
    }
}
