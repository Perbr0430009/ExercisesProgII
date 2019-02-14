using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGadgets
{
    class BatVehicule
    {
        private string description;
        private List<BatGadgetVehicule> batGadgets;
        public BatVehicule(string description)
        {

            Console.WriteLine("Constructeur: BatVehicule");
            this.description = description;
            batGadgets = new List<BatGadgetVehicule>();
        }

        public void SetBatGadget(BatGadgetVehicule nouveauBatGadget)
        {
            batGadgets.Add(nouveauBatGadget);
        }
    }
}
