using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Studente : Persona
    {

        public Studente(string nome) : base(nome)
        {
            Matricola++;
        }

        public int Matricola { get; private set; }
    }
}
