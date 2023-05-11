using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[30];

            Random x = new Random();
            while (!Console.KeyAvailable)
            {
                Array[x.Next(30)] = x.Next(30);
                Console.WriteLine(x.Next(30));
                Thread.Sleep(1000);
            }

            Console.ReadLine();

        }
    }
}
