using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la data:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            int giorno = int.Parse(Console.ReadLine());
            int mese = int.Parse(Console.ReadLine());
            int data = int.Parse(Console.ReadLine());
            Data(ref giorno, ref mese, ref data, 0);
            while (giorno > 31 || mese > 12)
            {
                giorno = int.Parse(Console.ReadLine());
                mese = int.Parse(Console.ReadLine());
            }
        }
        static bool Data(ref int giorno, ref int mese, ref int data, int resto)
        {
            bool risultato=true;
            if (risultato)
            {
                
                
                if (resto == data % 4)
                {
                    risultato = true;
                }
            }
            return risultato;
           
        }
    }
}
