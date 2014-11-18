using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    enum EBoisson
    {
        Aucune,
        Expresso,
        CaféLong,
        ExpressoGrains,
        CaféLonggrains,
        Chocolat,
        Capuccino
    };

    enum EIngredient
    {
        Cannelle = 1,
        Lait = 2,
        Chantilly = 3,
        Caramel = 4
    };

    enum EEtat
    {
        PasDePiece = 0,
        Selection = 1,
        EnCoursDeLivraison = 2,
        Gagnant = 3,
        EnMaintenance = 4
    };

    class Boisson
    {
        private double Cout { get; set; }
        private string Nom { get; set; }
        private int NombreDoses { get; set; }

        public Boisson(string unNom, double unCout, int nbreDoses)
        {
            Nom = unNom;
            Cout = unCout;
            NombreDoses = nbreDoses;
        }
    }
}
