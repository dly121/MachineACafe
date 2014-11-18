using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    class EtatSelection : EtatAbstrait
    {
        private Random rand;

        public override void ChoisirIngredient(EIngredient unIngredient)
        {
            throw new NotImplementedException();
        }

        public override void ChoisirSucre(int dosage)
        {
            throw new NotImplementedException();
        }

        public override void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            Console.WriteLine(EBoisson.Expresso + "2.40 euros");
            Console.WriteLine(EBoisson.ExpressoGrains + "2.50 euros");
            Console.WriteLine(EBoisson.CaféLong + "2.50 euros");
            Console.WriteLine(EBoisson.CaféLonggrains + "2.60 euros");
            Console.WriteLine(EBoisson.Chocolat + "4.40 euros");
            Console.WriteLine(EBoisson.Capuccino + "4.50 euros");
        }

        public override void InsererMonnaie(double nbreEuros)
        {
            throw new NotImplementedException();
        }

        public override void PasserEnMaintenance()
        {
            throw new NotImplementedException();
        }

        public override void RecuperationGobelet()
        {
            throw new NotImplementedException();
        }

        public override void RecupererMonnaie()
        {
            throw new NotImplementedException();
        }

        public override void RendreMonnaie()
        {
            throw new NotImplementedException();
        }
    }
}
