using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilWar
{
    class WarMachine : SuperHero
    {
        public WarMachine() : base("War Machine", "Vol")
        {
            Console.WriteLine("Constructeur: War Machine");
        }
    }
}
