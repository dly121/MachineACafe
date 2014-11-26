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

        public override void RecupererGobelet()
        {
            machineACafe.RecupererGobelet();
            machineACafe.ChangeEtat(EEtat.PasDePiece);
        }

        public override void RecupererMonnaie()
        {
            throw new NotImplementedException();
        }

        public override void RendreMonnaie()
        {
            machineACafe.RendreMonnaie();
            machineACafe.ChangeEtat(EEtat.EnCoursDeLivraison);
        }
    }
}
