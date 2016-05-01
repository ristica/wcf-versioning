using System;
using System.ServiceModel;
using Demo.Services;

namespace Demo.Host1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HOST 1";

            var host = new ServiceHost(typeof(DemoManager1));
            host.Open();

            Console.WriteLine("Service started...");
            Console.WriteLine("Press <Enter> to close the service");
            Console.ReadKey();

            host.Close();
        }
    }
}
