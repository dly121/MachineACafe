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
            if (machineACafe.AssezArgent(machineACafe.BoissonCourante))
            {
                machineACafe.RecupererGobelet();
            }
            else
            {
                Console.WriteLine("Pas de gobelet à récupérer.\n");
            }
            machineACafe.ChangeEtat(EEtat.PasDePiece);
            machineACafe.tmp = 0.0;
            machineACafe.DosageSucre = 0;
            machineACafe.IngredientCourant = EIngredient.Aucun;
        }

        public override void RecupererMonnaie()
        {
            throw new NotImplementedException();
        }

        public override void RendreMonnaie()
        {
            if(machineACafe.AssezArgent(machineACafe.BoissonCourante))
            {
                machineACafe.RendreMonnaie();
                machineACafe.ChangeEtat(EEtat.EnCoursDeLivraison);
            }
        }
    }
}
