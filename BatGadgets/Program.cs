using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGadgets
{
    class Program
    {
        static void Main(string[] args)
        {
            Batman batman = new Batman();
            batman.SetBatGadget(new BatGadgetCape("Batarang"));
            batman.SetBatGadget(new BatGadgetCape("Bat-Ordinateur"));
            batman.SetBatGadget(new BatGadgetCape("Bat HookShot"));

            BatVehicule batcopter = new BatVehicule("Bat-Copter");
            batcopter.SetBatGadget(new BatGadgetVehicule("Bat Pilote"));
            batcopter.SetBatGadget(new BatGadgetVehicule("Bat Bouclier"));
            batcopter.SetBatGadget(new BatGadgetVehicule("Bat Ladder"));

            Console.ReadKey();

        }
    }
}
