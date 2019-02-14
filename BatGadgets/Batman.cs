using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGadgets
{
    class Batman
    {
        private List<BatGadgetCape> batGadgets;
        public Batman()
        {
            batGadgets = new List<BatGadgetCape>();
            Console.WriteLine("Constructeur: I'm BATMAN!!!");
        }

        public void SetBatGadget(BatGadgetCape nouveauBatGadget)
        {
            batGadgets.Add(nouveauBatGadget);
        }
    }
}
