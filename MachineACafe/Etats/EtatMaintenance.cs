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
            if (machineACafe.EtatCourant == EEtat.EnMaintenance)
            {
                machineACafe.RemplirIngredient();
                machineACafe.ChangeEtat(EEtat.PasDePiece);
                machineACafe.tmp = 0.0;
                machineACafe.DosageSucre = 0;
                machineACafe.IngredientCourant = EIngredient.Aucun;
            }
        }

        public override void RecupererGobelet()
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