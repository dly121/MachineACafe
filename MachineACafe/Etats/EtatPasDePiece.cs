using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal class EtatPasDePiece : EtatAbstrait
    {

        public EtatPasDePiece(MachineACafe uneMachine)
            : base(uneMachine)
        {
            machineACafe = uneMachine;
            machineACafe.ChangeEtat(EEtat.PasDePiece);
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
            if (nbreEuros <= 0)
            {
                Console.WriteLine("Insérer de la monnaie");
            }
            else
            {
                machineACafe.InsererMonnaie(nbreEuros); 
            }
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
            Console.WriteLine("Crédit: " + machineACafe.CalculRenduArgent());
        }

        public override void RendreMonnaie()
        {
            Console.WriteLine("Crédit: " + machineACafe.CalculRenduArgent());
        }
    }
}
