using System;
using System.Threading;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(Timeout.Infinite);
            // Console.ReadLine();
        }
    }
}
