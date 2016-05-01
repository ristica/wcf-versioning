using System;
using Demo.Contracts;

namespace Demo.Services
{
    public class DemoManager1 : IDemoService
    {
        public void DoSomething()
        {
            Console.WriteLine("DemoManager 1 => DoSomething()");
        }
    }
}
