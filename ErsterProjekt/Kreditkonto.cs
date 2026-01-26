
using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Kreditkonto : Bankkonto
    {
        public Kreditkonto(string kontoinhaber, string bank = "Parkbank", string filiale = "Wegberg")
            : base(kontoinhaber, bank, filiale)
        {
        }

        public override bool Auszahlen(decimal betrag, string ziel = "==========")
        {
            if (betrag <= 0)
            {
                Console.WriteLine("Ungültiger Betrag.");
                return false;
            }

            kontostand -= betrag;
            return true;
        }
    }
}