using System;
using System.ServiceModel;

using Contract;
using Service;





namespace Hosting
{
    class Host
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";

            ServiceHost host = new ServiceHost(typeof(MyService));
            host.AddServiceEndpoint(typeof(IContract), new BasicHttpBinding(), "http://localhost:8080/MyService");
            host.Open();

            Console.ReadKey();

            host.Close();
        }
    }
}
