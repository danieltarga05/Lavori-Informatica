using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "ciao", "pipppo", "aereoplano", "zinco", "frizione", "motore", "manuel" };
            string tmp;
            for (int x = 0; x < array.Length; x++)
            {
                for (int y = x; y < array.Length; y++)
                {
                    if (string.Compare(array[y], array[x])==-1)
                    {
                        tmp = array[y];
                        array[y] = array[x];
                        array[x] = tmp;
                    }
                }
            }
            foreach (string parola in array)
                Console.Write(parola+"\n");
            Console.ReadLine();
        }
    }
}
