using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilWar
{
    class SoldatHiver : SuperHero
    {
        public SoldatHiver() : base("Soldat de l'hiver", "Super Soldat")
        {
            Console.WriteLine("Constructeur: Soldat de l'hiver");
        }
    }
}
