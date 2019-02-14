using System;

namespace BatGadgets
{
    class BatGadgetVehicule : BatGadget
    {
        public BatGadgetVehicule(string nom): base(nom)
        {
            Console.WriteLine("Constructeur: BatGadgetVehicule");
        }
    }
}