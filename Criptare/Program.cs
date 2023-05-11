using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            string s = "Mydejdkejejf";
            Cripto(ref s);   
            Console.ReadLine();
        }
        static void Cripto(ref string parola)
        {
            foreach(int risultato in parola)
            {
                Console.Write(risultato);   
            }
        }
    }
}
