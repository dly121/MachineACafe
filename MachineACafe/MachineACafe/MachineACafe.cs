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
        internal double tmp { get; set; }

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
            tmp = 0.0;
            
        }

        public bool AssezArgent(EBoisson uneBoisson)
        {
            bool assez = false;

            foreach (var boisson in boissonDico)
            {
                if (uneBoisson == boisson.Key &&
                    tmp >= boisson.Value.Cout)
                {
                    assez = true;
                    break;
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
                    tmp >= boisson.Value.Cout)
                {
                    rendu = tmp - boisson.Value.Cout;
                    break;
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
            if (IngredientCourant != unIngredient)
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
            Console.WriteLine("Boisson choisie: {0}", uneBoisson);
            if (this.EtatCourant == EEtat.Gagnant)
                Console.WriteLine("VOUS GAGNEZ UN CHOCOLAT CHAUD!!!!");
            else if (uneBoisson != EBoisson.Aucune)
            {
                if (this.AssezArgent(uneBoisson))
                {
                    BoissonCourante = uneBoisson;
                    foreach (var boisson in this.boissonDico)
                    {
                        if (uneBoisson.ToString() == boisson.Value.getNom())
                        {
                            Console.WriteLine("En préparation: {0}", BoissonCourante.ToString());
                            Console.WriteLine("Prix: {0} euros", boisson.Value.getCout());
                            ArgentRecupere += boisson.Value.Cout;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Pas assez d'argent.");
                }
            }
        }

        public void InsererMonnaie(double nbreEuros)
        {
            if (nbreEuros == 2 || nbreEuros == 1 || nbreEuros == 0.5 || nbreEuros == 0.2 || nbreEuros == 0.1)
            {
                tmp += nbreEuros;
                Console.WriteLine("Vous avez inséré {0} euros.", nbreEuros);
                Console.WriteLine("Argent en instance: {0} euros.", tmp);
            }
            else
            {
                Console.WriteLine("Pièce non prise en charge: {0}", nbreEuros);
                this.RecupererMonnaie();
            }
        }

        public void PasserEnMaintenance()
        {
            if (this.EtatCourant == EEtat.PasDePiece)
            {
                Console.WriteLine("Etat courant: {0}", EtatCourant);
                if (EtatCourant == EEtat.EnMaintenance)
                    Console.WriteLine("Réapprovissionnement des boissons...");
            }
        }

        public void RecupererGobelet()
        {
            if (this.BoissonCourante != EBoisson.Aucune)
            {
                if (EtatCourant == EEtat.Gagnant)
                    Console.WriteLine("Récupérer le gobelet: Chocolat offert!");
                else if (this.AssezArgent(BoissonCourante))
                {
                    Console.WriteLine("Récupérer le gobelet: {0}, {1}, {2} sucre(s)", BoissonCourante, IngredientCourant, DosageSucre);
                    tmp = 0.0;
                }
            }
            else Console.WriteLine("Aucun gobelet à récupérer.\n");

            Console.WriteLine("\nArgent total récupéré: {0} euros\n", ArgentRecupere);
        }

        public void RecupererMonnaie()
        {
            Console.WriteLine("Recupérer la monnaie.");
        }

        public void RemplirIngredient()
        {
            Console.WriteLine("En cours de réapprovisionnement d'ingrédients.");
        }

        public void RendreMonnaie()
        {
            if(this.AssezArgent(BoissonCourante))
            {
                Console.WriteLine("Récupérer votre monnaie: {0} euros", this.CalculRenduArgent());
            }
        }

    }
}
