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
        Aucune,
        Expresso,
        CaféLong,
        ExpressoGrains,
        CaféLongGrains,
        Chocolat,
        Capuccino
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

    internal class Boisson
    {
        internal string Nom { get; set; }
        internal double Cout { get; set; }
        internal int NombreDoses { get; set; }

        public Boisson(string unNom, double unCout, int nbreDoses)
        {
            Nom = unNom;
            Cout = unCout;
            NombreDoses = nbreDoses;
        }

        public string getNom()
        {
            return Nom;
        }

        public double getCout()
        {
            return Cout;
        }
    }
}
