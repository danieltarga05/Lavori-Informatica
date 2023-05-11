using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace FlottaNavake
{

     internal class Nave
     {
        string nome;
        string stazza;
        string velocita;
        StatoNave statoNave;
        List<Nave> flottaNave = new List<Nave>();
        public Nave(string nome, string stazza, string velocita, StatoNave statoNave)
        {
            Nome = nome;
            Stazza = stazza;
            Velocita = velocita;
            StatoNave = statoNave;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Stazza { get => stazza; set => stazza = value; }
        public string Velocita { get => velocita; set => velocita = value; }
        internal StatoNave StatoNave { get => statoNave; set => statoNave = value; }

        public bool AggiungiNave(Nave aggiunta)
        {
            if (flottaNave.Contains(aggiunta) || Nome.Length > 20 || Stazza.Length > 4 || Velocita.Length > 3)
                return false;
            flottaNave.Add(aggiunta);
            return true;
        }

       
     }
}