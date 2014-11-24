using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    class MachineACafe
    {
        private Dictionary<EBoisson, Boisson> boissonDico;
        private double ArgentRecupere { get; set; }
        private EBoisson BoissonCourante { get; set; }
        private int DosageSucre { get; set; }
        private EEtat EtatCourant { get; set; }
        private EIngredient IngredientCourant { get; set; }

        public bool AssezArgent(EBoisson uneBoisson)
        {
            if (uneBoisson != EBoisson.Aucune)
            {
                try
                {
                    double argent = (double)Enum.Parse(typeof(EBoisson), uneBoisson.ToString());
                    if (ArgentRecupere >= argent)
                    {
                        ArgentRecupere -= argent; 
                        return true;
                    }
                    else return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur méthode AssezArgent()" + ex);
                }

            }
            return false;
        }

        public double CalculRenduArgent()
        {
            return ArgentRecupere;
        }

        public void ChangeEtat(EEtat nouvelEtat)
        {
            if (EtatCourant != nouvelEtat)
            {
                EtatCourant = nouvelEtat;
                Console.WriteLine("Nouvel état: " + EtatCourant);
            }
        }

        public void ChoisirIngredient(EIngredient unIngredient)
        {
            if (IngredientCourant != EIngredient.Aucun)
            {
                IngredientCourant = unIngredient;
                Console.WriteLine("Nouvel ingrédient: " + IngredientCourant);
            }
            else Console.WriteLine("Vous avez déjà sélectionné l'ingrédient: " + IngredientCourant);
        }

        public void ChoisirSucre(int dosage)
        {
            if (dosage < 0 && dosage > 5)
                Console.WriteLine("Dosage sucre invalide.");
            else
            {
                DosageSucre = dosage;
                Console.WriteLine("Dosage sucre: " + DosageSucre);
            }
        }

        public void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            if (uneBoisson != EBoisson.Aucune)
            {
                

                BoissonCourante = uneBoisson;
                Console.WriteLine("Boisson choisie: " + BoissonCourante);
            }
        }

        public void InsererMonnaie(double nbreEuros)
        {
            ArgentRecupere = nbreEuros;
            Console.WriteLine("Vous avez inséré " + ArgentRecupere + " euros.");
        }

        public MachineACafe()
        {
            ArgentRecupere = 0.0;
            BoissonCourante = EBoisson.Aucune;
            DosageSucre = 0;
            IngredientCourant = EIngredient.Aucun;
        }

        public void PasserEnMaintenance()
        {
            EtatCourant = EEtat.EnMaintenance;
            Console.WriteLine("Etat courant: " + EtatCourant);
        }

        public void RecuperationGobelet()
        {
            Console.WriteLine("Récupérer le gobelet.");
        }

        public void RecuperationMonnaie()
        {
            Console.WriteLine("Recupérer la monnaie.");
        }

        public void RemplirIngredient()
        {
            Console.WriteLine("En cours de réapprovisionnement d'ingrédients.");
        }

        public void RendreMonnaie()
        {
            Console.WriteLine("Récupérer votre monnaie: " + ArgentRecupere);
        }

    }
}
