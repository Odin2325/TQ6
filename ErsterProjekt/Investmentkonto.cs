using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Investmentkonto : Bankkonto
    {
        private readonly DateTime sperrdatum = new DateTime(2060, 1, 1);

        public Investmentkonto(string kontoinhaber, string bank = "Parkbank", string filiale = "Wegberg")
            : base(kontoinhaber, bank, filiale)
        {
        }

        public override bool Auszahlen(decimal betrag, string ziel = "==========")
        {
            if (DateTime.Now < sperrdatum)
            {
                Console.WriteLine("Auszahlungen vor dem 01.01.2060 sind nicht erlaubt.");
                return false;
            }

            return base.Auszahlen(betrag, ziel); 
        }


        public void MonatlicheZinsen()
        {
            kontostand *= 1.0125m;
            Console.WriteLine($"Monatliche Zinsen angewendet. Neuer Kontostand: {kontostand:F2} EUR");
        }
    }
}
