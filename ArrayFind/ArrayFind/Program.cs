using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFind
{
    internal class Program
    {
        static string lettura;
        struct Studente
        {
            public string nome;
            public int eta;
        }
        static void Main(string[] args)
        {
            List<Studente> mylist = new List<Studente>();
            mylist.Add(new Studente() { nome = "Manuel", eta = 17 });
            mylist.Add(new Studente() { nome = "Emiliano", eta = 38 });
            mylist.Add(new Studente() { nome = "Elmo", eta = 89 });
            mylist.Add(new Studente() { nome = "Antonino", eta = 17 });
            lettura = Console.ReadLine();
            Console.WriteLine(mylist.Find(Match));
            Console.ReadLine();
            
        }

        static bool Match(Studente st)
        {
            return st.nome == lettura;
        }

    }
}

