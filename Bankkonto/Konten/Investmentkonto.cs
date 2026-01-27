using Bankkonto.Buchungen;
using System;

namespace Bankkonto.Konten
{
    public class Investmentkonto : Bankkonto
    {
        private static readonly DateTime AuszahlungErlaubtAb =
            new DateTime(2060, 1, 1);

        private const decimal Monatszins = 0.0125m;

        public Investmentkonto(
            string kontoinhaber,
            string kontonummer,
            decimal startguthaben = 0m)
            : base(kontoinhaber, kontonummer, startguthaben)
        {
        }

        protected override bool DarfAuszahlen(decimal betrag)
        {
            if (DateTime.Now < AuszahlungErlaubtAb)
                return false;

            return base.DarfAuszahlen(betrag);
        }

        public void BucheMonatlicheZinsen()
        {
            if (Kontostand <= 0)
                return;

            decimal zinsen = Kontostand * Monatszins;
            Kontostand += zinsen;

            Buche(zinsen, Buchungsart.Zinsen, "Monatliche Investment-Zinsen (1,25 %)");
        }
    }
}