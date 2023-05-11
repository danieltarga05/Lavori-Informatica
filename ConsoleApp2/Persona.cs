using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Persona
    {
        public string Nome { get; set; }
        public Persona()
        {
            Nome = "Manuel";
        }

        public Persona(string nome)
        {
            Nome = nome;
        }


    }
}
