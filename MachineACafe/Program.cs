using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MachineACafe distributeur = new MachineACafe();

            EtatPasDePiece pasDePiece = new EtatPasDePiece(distributeur);
            EtatSelection enSelection = new EtatSelection(distributeur);
            EtatGagnant gagnant = new EtatGagnant(distributeur);
            EtatEnCoursDeLivraison enLivraison = new EtatEnCoursDeLivraison(distributeur);
            EtatMaintenance enMaintenance = new EtatMaintenance(distributeur);

            pasDePiece.InsererMonnaie(2);
            pasDePiece.InsererMonnaie(2);
            enSelection.ChoisirSucre(3);
            enSelection.ChoisirIngredient(EIngredient.Lait);
            enSelection.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.RecupererGobelet();
            enLivraison.RendreMonnaie();
            enLivraison.RecupererGobelet();

            pasDePiece.InsererMonnaie(2);
            pasDePiece.InsererMonnaie(2);
            pasDePiece.PasserEnMaintenance();
            enMaintenance.PasserEnMaintenance();
            enSelection.ChoisirSucre(3);
            enSelection.ChoisirIngredient(EIngredient.Lait);
            enSelection.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.RecupererGobelet();
            enLivraison.RendreMonnaie();
            enLivraison.RecupererGobelet();

            pasDePiece.InsererMonnaie(2);
            pasDePiece.InsererMonnaie(2);
            enSelection.ChoisirSucre(3);
            enSelection.ChoisirIngredient(EIngredient.Lait);
            enSelection.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.RecupererGobelet();
            enLivraison.RendreMonnaie();
            enLivraison.RecupererGobelet();
            
            pasDePiece.InsererMonnaie(1);
            pasDePiece.InsererMonnaie(0.5);
            enSelection.ChoisirSucre(2);
            enSelection.ChoisirIngredient(EIngredient.Cannelle);
            enSelection.ChoisirUneBoisson(EBoisson.CaféLong);
            gagnant.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.RecupererGobelet();
            enLivraison.RendreMonnaie();
            enLivraison.RecupererGobelet();

            pasDePiece.InsererMonnaie(1);
            pasDePiece.InsererMonnaie(0.8);
            pasDePiece.PasserEnMaintenance();
            enMaintenance.PasserEnMaintenance();
            enSelection.ChoisirSucre(2);
            enSelection.ChoisirIngredient(EIngredient.Caramel);
            enSelection.ChoisirUneBoisson(EBoisson.Capuccino);
            gagnant.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.RecupererGobelet();
            enLivraison.RendreMonnaie();
            enLivraison.RecupererGobelet();

            pasDePiece.InsererMonnaie(1);
            pasDePiece.InsererMonnaie(0.8);
            enSelection.ChoisirSucre(2);
            enSelection.ChoisirIngredient(EIngredient.Chantilly);
            enSelection.ChoisirUneBoisson(EBoisson.Aucune);
            gagnant.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.RecupererGobelet();
            enLivraison.RendreMonnaie();
            enLivraison.RecupererGobelet();

            pasDePiece.InsererMonnaie(2);
            pasDePiece.InsererMonnaie(2);
            pasDePiece.InsererMonnaie(2);
            enSelection.ChoisirSucre(2);
            enSelection.ChoisirIngredient(EIngredient.Chantilly);
            enSelection.ChoisirUneBoisson(EBoisson.Capuccino);
            gagnant.ChoisirUneBoisson(EBoisson.ExpressoGrains);
            gagnant.RecupererGobelet();
            enLivraison.RendreMonnaie();
            enLivraison.RecupererGobelet();

            Console.ReadLine();
        }
    }
}
