using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilWar
{
    class SuperHero
    {
        private string nom;
        private string superPouvoir;

        protected SuperHero(string nom, string superPouvoir)
        {
            this.nom = nom;
            this.superPouvoir = superPouvoir;
            Console.WriteLine("Constructeur: SuperHero");
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetSuperPouvoir()
        {
            return superPouvoir;
        }
    }
}