using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collezioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack");
            Stack<int> ints = new Stack<int>();
            Stack pila = new Stack();
            ints.Push(1);
            ints.Push(2);
            ints.Push(15);//numero di adani
            ints.Push(24);

            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }

            ints.Pop();

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            pila.Push(65);
            pila.Push("Lele Adani difensore della nazionale italiana");
            pila.Push(2);

            foreach (object i in pila)
            {
                Console.WriteLine(i);
            }

            object obj = pila.Pop();
            Console.WriteLine(obj);
        }
    }
}
