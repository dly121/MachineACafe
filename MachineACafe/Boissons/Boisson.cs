using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe.Boissons
{
    enum EBoisson : long
    {
        Aucune = 0,
        Expresso = 2.40,
        CaféLong = 3.40,
        ExpressoGrains = 2.50,
        CaféLongGrains = 3.60,
        Chocolat = 4.40,
        Capuccino = 4.50
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
        private EBoisson eBoisson;
        private double p1;
        private int p2;

        private double Cout { get; set; }
        private string Nom { get; set; }
        private int NombreDoses { get; set; }

        public Boisson(string unNom, double unCout, int nbreDoses)
        {
            Nom = unNom;
            Cout = unCout;
            NombreDoses = nbreDoses;
        }

        public Boisson(EBoisson eBoisson, double p1, int p2)
        {
            // TODO: Complete member initialization
            this.eBoisson = eBoisson;
            this.p1 = p1;
            this.p2 = p2;
        }
    }
}
