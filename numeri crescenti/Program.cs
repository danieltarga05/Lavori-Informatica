using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeri_crescenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nDis = new int[] { 10, 2, 3, 4, 30, 20, 31, 42, 51, 60 };
            int[] nOrd = new int[nDis.Length];
            int numMinore, contatore=nDis.Length;
            for (int i=0; i<nDis.Length; i++)
            {
                numMinore= nDis[i];
                for(int t=0; t < contatore; t++)
                {
                    if (nDis[t] < nDis[i])
                    {
                        numMinore = nDis[t];
                        nDis[t] = nDis[i];
                    }
                }
                nDis[i] = numMinore;
                contatore--;
            }
            for(int stampa=0; stampa<nDis.Length; stampa++)
            {
                Console.WriteLine(nDis[stampa]);
            }
            Console.ReadLine();
        }
    }
}
