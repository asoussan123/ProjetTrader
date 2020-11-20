using System;
using System.Collections.Generic;
using System.Text;

namespace MetierTrader
{
    public class ActionPerso
    {
        int idAction;
        string nomAction;
        double coursReel;

        public ActionPerso(int unId, string unNom, double unCours)
        {
            IdAction = unId;
            NomAction = unNom;
            CoursReel = unCours;
        }

        public ActionPerso(int unId, string unNom)
        {
            IdAction = unId;
            NomAction = unNom;
        }

        public int IdAction { get => idAction; set => idAction = value; }
        public string NomAction { get => nomAction; set => nomAction = value; }
        public double CoursReel { get => coursReel; set => coursReel = value; }
    }
}
