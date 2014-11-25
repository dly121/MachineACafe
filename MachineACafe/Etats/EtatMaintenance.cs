using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal class EtatMaintenance : EtatAbstrait
    {
        public EtatMaintenance(MachineACafe uneMachine)
            : base(uneMachine)
        {
            machineACafe = uneMachine;
            machineACafe.ChangeEtat(EEtat.EnMaintenance);
        }

        public override void ChoisirIngredient(EIngredient unIngredient)
        {
            Console.WriteLine("En maintenance");
        }

        public override void ChoisirSucre(int dosage)
        {
            throw new NotImplementedException();
        }

        public override void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            throw new NotImplementedException();
        }

        public override void InsererMonnaie(double nbreEuros)
        {
            throw new NotImplementedException();
        }

        public override void PasserEnMaintenance()
        {
            machineACafe.PasserEnMaintenance();
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