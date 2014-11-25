using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal class EtatSelection : EtatAbstrait
    {
        private Random rand;

        public EtatSelection(MachineACafe uneMachine)
            : base(uneMachine)
        {
            machineACafe = uneMachine;
            machineACafe.ChangeEtat(EEtat.Selection);
            rand = null;
        }

        public override void ChoisirIngredient(EIngredient unIngredient)
        {
            machineACafe.ChoisirIngredient(unIngredient);
        }

        public override void ChoisirSucre(int dosage)
        {
            machineACafe.ChoisirSucre(dosage);
        }

        public override void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            machineACafe.ChoisirUneBoisson(uneBoisson);
            /*
            switch(uneBoisson)
            {
                case EBoisson.Expresso:
                    Console.WriteLine(EBoisson.Expresso + "2.40 euros");
                    break;
                case EBoisson.ExpressoGrains:
                    Console.WriteLine(EBoisson.ExpressoGrains + "2.50 euros");
                    break;
                case EBoisson.CaféLong:
                    Console.WriteLine(EBoisson.CaféLong + "2.50 euros");
                    break;
                case EBoisson.CaféLongGrains:
                    Console.WriteLine(EBoisson.CaféLongGrains + "2.60 euros");
                    break;
                case EBoisson.Chocolat:
                    Console.WriteLine(EBoisson.Chocolat + "4.40 euros");
                    break;
                case EBoisson.Capuccino:
                    Console.WriteLine(EBoisson.Capuccino + "4.50 euros");
                    break;
                default : Console.WriteLine(EBoisson.Aucune + " boisson sélectionnée.");
                    break;
            }
            */
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
