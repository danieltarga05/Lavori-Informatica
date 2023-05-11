using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collezioni2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Lele");
            queue.Enqueue("Cassano");
            queue.Enqueue("Ventola");
            queue.Enqueue("Bobo");
            foreach(string i in queue)
            {
                Console.WriteLine(i);
            }

        }
    }
}
