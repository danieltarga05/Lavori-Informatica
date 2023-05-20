using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbronks
{
    internal class Clienti
    {
        public string Nome { get; private set; }
        public string Cf { get; private set; }
        public int Conto { get; private set; }
        public Clienti (string nome, string cf, int conto)
        {
            Nome = nome;    
            Cf = cf;
            Conto = conto;
        }
    }

    class Banca
    {
        List<Clienti> clienti;
        string NomeBanca { get; }
        public static int Conto { get; private set; }

        public Banca(string nomeBanca)
        {
            NomeBanca = nomeBanca;
            clienti = new List<Clienti>();
        }

        public bool AggiungiCliente(Clienti c)
        {
            if (!clienti.Exists(x => x == c))
            {
                clienti.Add(c);
                return true;
            }
            return false;
        }
    }
}
