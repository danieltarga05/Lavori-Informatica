using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studente s1 = new Studente("Martino");
            Console.WriteLine(s1.Nome + " " + s1.Matricola);
        }
    }
}
