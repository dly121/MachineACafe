using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachineACafe.Boissons;

namespace MachineACafe
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Initialisation des boissons
            var aucune = new Boisson(EBoisson.Aucune, 0, 0);
            var expresso = new Boisson(EBoisson.Expresso, 2.40, 1);
            var cafeLong = new Boisson(EBoisson.CaféLong, 2.50, 2);
            var expressoGrains = new Boisson(EBoisson.ExpressoGrains, 2.50, 1);
            var cafeLongGrains = new Boisson(EBoisson.CaféLongGrains, 2.60, 2);
            var chocolat = new Boisson(EBoisson.Chocolat, 4.40, 1);
            var capuccino = new Boisson(EBoisson.Capuccino, 4.50, 2);


        }
    }
}
