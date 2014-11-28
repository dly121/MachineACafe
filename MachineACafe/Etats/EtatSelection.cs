using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal class EtatSelection : EtatAbstrait
    {
        internal int randomValue;
        internal Random rand;

        public EtatSelection(MachineACafe uneMachine)
            : base(uneMachine)
        {
            machineACafe = uneMachine;
            randomValue = 0;
            rand = new Random();
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
            if (machineACafe.AssezArgent(uneBoisson))
            {
                randomValue = rand.Next(0, 100);
                if (randomValue <= 10)
                {
                    machineACafe.ChangeEtat(EEtat.Gagnant);
                }
                else machineACafe.ChangeEtat(EEtat.EnCoursDeLivraison);
            }
            else
            {
                machineACafe.ChangeEtat(EEtat.PasDePiece);
                machineACafe.tmp = 0.0;
            }
        }

        public override void InsererMonnaie(double nbreEuros)
        {
            machineACafe.InsererMonnaie(nbreEuros);
            machineACafe.ChangeEtat(EEtat.Selection);
        }

        public override void PasserEnMaintenance()
        {
            throw new NotImplementedException();
        }

        public override void RecupererGobelet()
        {
            throw new NotImplementedException();
        }

        public override void RecupererMonnaie()
        {
            machineACafe.RecupererMonnaie();
            machineACafe.ChangeEtat(EEtat.PasDePiece);
        }

        public override void RendreMonnaie()
        {
            throw new NotImplementedException();
        }
    }
}
