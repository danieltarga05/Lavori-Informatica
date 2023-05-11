using Classe_Nave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseNave
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Nave nave = new Nave();
            nave.SetNome("Costa Concordia");
            nave.StampaAVideo();



        }
    }
}
