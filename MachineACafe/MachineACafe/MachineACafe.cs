using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal class MachineACafe
    {
        internal Dictionary<EBoisson, Boisson> boissonDico;
        internal double ArgentRecupere { get; set; }
        internal EBoisson BoissonCourante { get; set; }
        internal int DosageSucre { get; set; }
        internal EEtat EtatCourant { get; set; }
        internal EIngredient IngredientCourant { get; set; }

        public MachineACafe()
        {
            ArgentRecupere = 0.0;
            BoissonCourante = EBoisson.Aucune;
            DosageSucre = 0;
            EtatCourant = EEtat.PasDePiece;
            IngredientCourant = EIngredient.Aucun;
            boissonDico = new Dictionary<EBoisson, Boisson>();
            boissonDico.Add(EBoisson.Aucune, new Boisson(EBoisson.Aucune.ToString(), 0, 0));
            boissonDico.Add(EBoisson.Expresso, new Boisson(EBoisson.Expresso.ToString(), 2.40, 1));
            boissonDico.Add(EBoisson.CaféLong, new Boisson(EBoisson.CaféLong.ToString(), 3.40, 2));
            boissonDico.Add(EBoisson.ExpressoGrains, new Boisson(EBoisson.ExpressoGrains.ToString(), 2.50, 1));
            boissonDico.Add(EBoisson.CaféLongGrains, new Boisson(EBoisson.CaféLongGrains.ToString(), 3.50, 2));
            boissonDico.Add(EBoisson.Chocolat, new Boisson(EBoisson.Chocolat.ToString(), 4.40, 2));
            boissonDico.Add(EBoisson.Capuccino, new Boisson(EBoisson.Capuccino.ToString(), 4.50, 2));
            
        }

        public bool AssezArgent(EBoisson uneBoisson)
        {
            bool assez = false;

            foreach (var boisson in boissonDico)
            {
                if (uneBoisson == boisson.Key &&
                    ArgentRecupere >= boisson.Value.Cout)
                {
                    assez = true;
                }
            }

            return assez;
        }

        public double CalculRenduArgent()
        {
            double rendu = 0.0;

            foreach (var boisson in boissonDico)
            {
                if (BoissonCourante.ToString() == boisson.Value.Nom.ToString() &&
                    ArgentRecupere >= boisson.Value.Cout)
                {
                    return ArgentRecupere - boisson.Value.Cout;
                }
            }
            if (rendu == 0.0)
                Console.WriteLine("Pas assez d'argent");
            return rendu;
        }

        public void ChangeEtat(EEtat nouvelEtat)
        {
            if (EtatCourant != nouvelEtat)
            {
                EtatCourant = nouvelEtat;
                Console.WriteLine("Nouvel état: {0}", EtatCourant.ToString());
            }
        }

        public void ChoisirIngredient(EIngredient unIngredient)
        {
            if (IngredientCourant != EIngredient.Aucun)
            {
                IngredientCourant = unIngredient;
                Console.WriteLine("Nouvel ingrédient: {0}", IngredientCourant.ToString());
            }
            else if (IngredientCourant == unIngredient)
                Console.WriteLine("Vous avez déjà sélectionné l'ingrédient: {0}", unIngredient.ToString());
            else Console.WriteLine("Choix de l'ingrédient \"{0}\" impossible", unIngredient.ToString());
        }

        public void ChoisirSucre(int dosage)
        {
            if (dosage < 0 && dosage > 5)
                Console.WriteLine("Dosage sucre invalide.");
            else
            {
                DosageSucre = dosage;
                Console.WriteLine("Dosage sucre: {0}", DosageSucre);
            }
        }

        public void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            if (uneBoisson != EBoisson.Aucune)
            {
                BoissonCourante = uneBoisson;
                Console.WriteLine("Boisson choisie: {0}", BoissonCourante.ToString());
            }
        }

        public void InsererMonnaie(double nbreEuros)
        {
            if (nbreEuros == 2 || nbreEuros == 1 || nbreEuros == 0.5 || nbreEuros == 0.2 || nbreEuros == 0.1)
            {
                ArgentRecupere += nbreEuros;
                Console.WriteLine("Vous avez inséré {0} euros.", nbreEuros);
                Console.WriteLine("Argent récupéré: {0}", ArgentRecupere);
            }
            else
            {
                this.RecupererMonnaie();
            }
        }

        public void PasserEnMaintenance()
        {
            this.ChangeEtat(EEtat.EnMaintenance);
            Console.WriteLine("Etat courant: {0}", EtatCourant);
        }

        public void RecuperationGobelet()
        {
            this.ChangeEtat(EEtat.EnCoursDeLivraison);
            Console.WriteLine("Récupérer le gobelet.");
        }

        public void RecupererMonnaie()
        {
            this.ChangeEtat(EEtat.Selection);
            Console.WriteLine("Recupérer la monnaie.");
        }

        public void RemplirIngredient()
        {
            this.ChangeEtat(EEtat.EnMaintenance);
            Console.WriteLine("En cours de réapprovisionnement d'ingrédients.");
        }

        public void RendreMonnaie()
        {
            this.ChangeEtat(EEtat.EnCoursDeLivraison);
            Console.WriteLine("Récupérer votre monnaie.{0}", ArgentRecupere);
        }

    }
}
