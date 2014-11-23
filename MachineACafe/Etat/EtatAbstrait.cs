using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachineACafe.Boissons;

namespace MachineACafe.Etat
{
    abstract class EtatAbstrait
    {
        MachineACafe machineACafe;

        public abstract void ChoisirIngredient(EIngredient unIngredient);
        public abstract void ChoisirSucre(int dosage);
        public abstract void ChoisirUneBoisson(EBoisson uneBoisson);
        public abstract void InsererMonnaie(double nbreEuros);
        public abstract void PasserEnMaintenance();
        public abstract void RecuperationGobelet();
        public abstract void RecupererMonnaie();
        public abstract void RendreMonnaie();

        public EtatAbstrait(MachineACafe uneMachine)
        {
            machineACafe = new MachineACafe();
        }
    }
}
