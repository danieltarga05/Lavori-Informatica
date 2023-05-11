using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlottaNavake
{
    internal class Flotta
    {
        string _flotta;
        string _armatore;
        string _sede;
        public Flotta(string flotta, string armatore, string sede)
        {
            FLotta = flotta;
            Armatore = armatore;
            Sede = sede;
        }

        public string FLotta { get => _flotta; set => _flotta = value; }
        public string Armatore { get => _armatore; set => _armatore = value; }
        public string Sede { get => _sede; set => _sede = value; }
    }
}
