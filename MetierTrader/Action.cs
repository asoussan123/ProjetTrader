using System;
using System.Collections.Generic;
using System.Text;

namespace MetierTrader
{
    public class Action
    {
        private int numAction;
        private string nomAction;
        private double coursReel;

        public Action(int unNum, string unNom, double unCours)
        {
            NumAction = unNum;
            NomAction = unNom;
            CoursReel = unCours;
        }
        public Action(int unNum, string unNom)
        {
            NumAction = unNum;
            NomAction = unNom;
        }
        public int NumAction { get => numAction; set => numAction = value; }
        public string NomAction { get => nomAction; set => nomAction = value; }
        public double CoursReel { get => coursReel; set => coursReel = value; }
    }
}
