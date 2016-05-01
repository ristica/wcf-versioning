using System;

namespace Demo.Host2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HOST 2";

            Console.WriteLine("Service started...");
            Console.WriteLine("Press <Enter> to close the service");

            Console.ReadKey();
        }
    }
}
