using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilWar
{
    class IronMan : SuperHero
    {
        public IronMan() : base("Iron Man", "Milliardaire")
        {
            Console.WriteLine("Constructeur: Iron Man");
        }
    }
}
