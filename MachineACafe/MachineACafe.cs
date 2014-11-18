using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    class MachineACafe
    {
        private double ArgentRecupere { get; set; }
        private EBoisson BoissonCourante { get; set; }
        private int DosageSucre { get; set; }

        public bool AssezArgent(EBoisson uneBoisson)
        {
            return false;
        }

        public double CalculRenduArgent()
        {
            return 2.2;
        }

        public void ChangeEtat(EEtat nouvelEtat)
        {
        }

        public void ChoisirIngredient(EIngredient unIngredient)
        {
        }

        public void ChoisirSucre(int dosage)
        {
        }

        public void ChoisirUnBoisson(EBoisson uneBoisson)
        {
        }

        public void InsererMonnaie(double nbreEuros)
        {
        }

        public MachineACafe()
        {
        }

        public void PasserEnMaintenance()
        {
        }

        public void RecuperationGobelet()
        {
        }

        public void RecuperationMonnaie()
        {
        }

        public void RemplirIngredient()
        {
        }

        public void RendreMonnaie()
        {
        }

    }
}
