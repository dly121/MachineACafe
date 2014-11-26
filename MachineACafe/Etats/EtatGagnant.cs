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
            machineACafe.ChoisirUneBoisson(EBoisson.Chocolat);
            machineACafe.ChangeEtat(EEtat.EnCoursDeLivraison);
        }

        public override void InsererMonnaie(double nbreEuros)
        {
            throw new NotImplementedException();
        }

        public override void PasserEnMaintenance()
        {
            throw new NotImplementedException();
        }

        public override void RecupererGobelet()
        {
            machineACafe.RecupererGobelet();
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
