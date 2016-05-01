using System;

namespace Demo.Host1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HOST 1";

            Console.WriteLine("Service started...");
            Console.WriteLine("Press <Enter> to close the service");

            Console.ReadKey();
        }
    }
}
