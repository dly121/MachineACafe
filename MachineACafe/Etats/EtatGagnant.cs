using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal class EtatGagnant : EtatAbstrait
    {
        public EtatGagnant(MachineACafe uneMachine)
            : base(uneMachine)
        {
            machineACafe = uneMachine;
            machineACafe.ChangeEtat(EEtat.Gagnant);
            machineACafe.ChoisirUneBoisson(EBoisson.Chocolat);
        }

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
            machineACafe.ChoisirUneBoisson(uneBoisson);
            machineACafe.ChoisirUneBoisson(EBoisson.Chocolat);
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
