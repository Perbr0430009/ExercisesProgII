using System;

namespace BatGadgets
{
    class BatGadgetCape : BatGadget
    {
        public BatGadgetCape (string nom): base(nom)
        {
            Console.WriteLine("Constructeur: BatGadgetCape");
        }
    }
}