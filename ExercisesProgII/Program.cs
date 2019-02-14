using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilWar
{
    class Program
    {
        static void Main(string[] args)
        {
            Faction factionCaptaineAmerica = new Faction("Capitaine America");
            factionCaptaineAmerica.AjouterMembre(new CapitaineAmerica());
            factionCaptaineAmerica.AjouterMembre(new BlackWidow());
            factionCaptaineAmerica.AjouterMembre(new AntMan());
            factionCaptaineAmerica.AjouterMembre(new SoldatHiver());

            Console.WriteLine(factionCaptaineAmerica.GetInfoMembres());

            Faction factionIronMan = new Faction("Iron Man");
            factionIronMan.AjouterMembre(new IronMan());
            factionIronMan.AjouterMembre(new SpiderMan());
            factionIronMan.AjouterMembre(new WarMachine());
            factionIronMan.AjouterMembre(new PanthereNoire());

            Console.WriteLine(factionIronMan.GetInfoMembres());
            
            factionCaptaineAmerica.SupprimerMembre("Black Widow");
            factionCaptaineAmerica.SupprimerMembre("Antman");
            factionIronMan.SupprimerMembre("War Machine");

            Console.WriteLine(factionCaptaineAmerica.GetInfoMembres());
            Console.WriteLine(factionIronMan.GetInfoMembres());

            Console.ReadKey();

        }
    }
}
