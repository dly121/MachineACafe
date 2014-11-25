using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal class EtatEnCoursDeLivraison : EtatAbstrait
    {
        public EtatEnCoursDeLivraison(MachineACafe uneMachine)
            : base(uneMachine)
        {
            machineACafe = uneMachine;
            machineACafe.ChangeEtat(EEtat.EnCoursDeLivraison);
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
            throw new NotImplementedException();
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
            machineACafe.RecuperationGobelet();
        }

        public override void RecupererMonnaie()
        {
            machineACafe.RecupererMonnaie();
        }

        public override void RendreMonnaie()
        {
            machineACafe.RendreMonnaie();
        }
    }
}
