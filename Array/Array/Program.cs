using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Array

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = { 5, 2, 3, 7, 9, 4, 8 };
            int[] myarr2 = new int[7];
            Console.WriteLine("Posizione:" + Array.IndexOf(myarr, 7)); 
            Array.Copy(myarr, myarr2, 7); 
            Console.WriteLine("l'array copiato è");
            foreach (int i in myarr2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("l'array ordinato è");
            Array.Sort(myarr);
            foreach (int i in myarr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("La posizione dell'elemento cercato è" + " " + Array.BinarySearch(myarr, 10));
            Console.ReadLine();

        }


    }
}
