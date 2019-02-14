using System;

namespace BatGadgets
{
    class BatGadget
    {
        private string nom;
        public BatGadget(string nom)
        {

            Console.WriteLine("Constructeur: BatGadget");
            this.nom = nom;
        }

        public string getNom()
        {
            return nom;
        }
    }
}