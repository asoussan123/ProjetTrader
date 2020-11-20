using System;

namespace MetierTrader
{
    public class Trader
    {
        private int numTrader;
        private string nomTrader;

        public Trader(int unNum, string unNom)
        {
            NumTrader = unNum;
            NomTrader = unNom;
        }

        public int NumTrader { get => numTrader; set => numTrader = value; }
        public string NomTrader { get => nomTrader; set => nomTrader = value; }
    }
}
