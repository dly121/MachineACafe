using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachineACafe;

namespace MachineACafe
{
    enum EBoisson : long
    {
        Aucune = 0,
        Expresso = (long)2.40,
        CaféLong = (long)3.40,
        ExpressoGrains = (long)2.50,
        CaféLongGrains = (long)3.60,
        Chocolat = (long)4.40,
        Capuccino = (long)4.50
    };

    enum EIngredient
    {
        Aucun = 0,
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
        private EBoisson Nom { get; set; }
        private double Cout { get; set; }
        private int NombreDoses { get; set; }

        public Boisson(EBoisson unNom, double unCout, int nbreDoses)
        {
            Nom = unNom;
            Cout = unCout;
            NombreDoses = nbreDoses;
        }
    }
}
