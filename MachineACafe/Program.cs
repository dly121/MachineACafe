using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Initialisation des boissons
            var boissonDico = new Dictionary<EBoisson, Boisson>();
            boissonDico.Add(EBoisson.Aucune, new Boisson(EBoisson.Aucune, 0, 0));
            boissonDico.Add(EBoisson.Expresso, new Boisson(EBoisson.Expresso, 2.40, 1));
            boissonDico.Add(EBoisson.CaféLong, new Boisson(EBoisson.CaféLong, 3.40, 2));
            boissonDico.Add(EBoisson.ExpressoGrains, new Boisson(EBoisson.ExpressoGrains, 2.50, 1));
            boissonDico.Add(EBoisson.CaféLongGrains, new Boisson(EBoisson.CaféLongGrains, 3.50, 2));
            boissonDico.Add(EBoisson.Chocolat, new Boisson(EBoisson.Chocolat, 4.40, 2));
            boissonDico.Add(EBoisson.Capuccino, new Boisson(EBoisson.Capuccino, 4.50, 2));

            foreach (var boissons in boissonDico)
            {
                Console.WriteLine(boissonDico.Values.ToString());
            }

        }
    }
}
