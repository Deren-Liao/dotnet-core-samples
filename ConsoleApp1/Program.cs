using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Press X to quit.");
            while (Console.ReadKey().Key != ConsoleKey.X) { }
        }
    }
}
