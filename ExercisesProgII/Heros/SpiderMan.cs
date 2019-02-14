using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilWar
{
    class SpiderMan : SuperHero
    {
        public SpiderMan() : base("Spider Man", "Toile")
        {
            Console.WriteLine("Constructeur: Spider Man");
        }
    }
}
