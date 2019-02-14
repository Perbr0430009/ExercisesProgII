using System;
using System.Collections.Generic;

namespace CivilWar
{
    class Faction
    {
        string nom;
        List<SuperHero> membres;
        public Faction(string factionName)
        {
            nom = factionName;
            membres = new List<SuperHero>();
            Console.WriteLine("Création de la faction " + nom);
        }

        public void AjouterMembre(SuperHero nouveauHero)
        {
            membres.Add(nouveauHero);
        }

        public void SupprimerMembre(string heroASuprimmer)
        {
            bool aEteSupprimer = false;
            int i = 0;
            while(!aEteSupprimer && i < membres.Count)
            {
                if (membres[i].GetNom() == heroASuprimmer)
                {
                    membres.RemoveAt(i);
                    aEteSupprimer = true;
                }
                i++;
            }
        }

        public string GetInfoMembres()
        {
            string infoMembres = "Les membres de la faction "+ nom + "\n";
            foreach (SuperHero membre in membres)
            {
                infoMembres += membre.GetNom() + " (" + membre.GetSuperPouvoir() + ")\n";
            }
            return infoMembres;
        }
       
    }
}