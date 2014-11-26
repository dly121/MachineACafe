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
            enLivraison.RendreMonnaie();
            enLivraison.RecupererGobelet();

            Console.ReadLine();
        }
    }
}
