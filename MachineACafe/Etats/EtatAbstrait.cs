using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal abstract class EtatAbstrait
    {
        protected internal MachineACafe machineACafe;

        public abstract void ChoisirIngredient(EIngredient unIngredient);
        public abstract void ChoisirSucre(int dosage);
        public abstract void ChoisirUneBoisson(EBoisson uneBoisson);
        public abstract void InsererMonnaie(double nbreEuros);
        public abstract void PasserEnMaintenance();
        public abstract void RecupererGobelet();
        public abstract void RecupererMonnaie();
        public abstract void RendreMonnaie();

        protected EtatAbstrait(MachineACafe uneMachine)
        {
        }

        public EtatAbstrait()
        {
            // TODO: Complete member initialization
        }
    }
}
