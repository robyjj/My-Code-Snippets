using System;

namespace DesignPatterns.Structural_Pattern
{
    public interface IClient
    {
        string GetData();
    }

    public class RealClient :IClient
    {
        string data;
        public RealClient()
        {
            Console.WriteLine("Real Client");
            data = "Real Cleint : Approved";
        }

        public string GetData()
        {
            return data;
        }
    }

    public class ProxyClient : IClient
    {
        IClient client;
        public ProxyClient()
        {
            client = new RealClient();
            Console.WriteLine("Proxy Client");
        }

        public string GetData()
        {
            //perform validations here
            return client.GetData();
        }
    }

    public class MainClass
    {
        public void Run()
        {
            ProxyClient proxy = new ProxyClient();
            proxy.GetData();    
        }
    }
}
