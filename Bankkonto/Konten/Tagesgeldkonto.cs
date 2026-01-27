using Bankkonto.Buchungen;
using System;

namespace Bankkonto.Konten
{
    public class Tagesgeldkonto : Bankkonto
    {
        private const decimal Tageslimit = 500m;
        private const decimal Monatszins = 0.007m;

        private DateTime letzterAuszahlungstag = DateTime.MinValue;
        private decimal heuteAusgezahlt = 0m;

        public Tagesgeldkonto(
            string kontoinhaber,
            string kontonummer,
            decimal startguthaben = 0m)
            : base(kontoinhaber, kontonummer, startguthaben)
        {
        }

        public override void Auszahlen(decimal betrag)
        {
            PruefeBetrag(betrag);

            if (DateTime.Today != letzterAuszahlungstag.Date)
            {
                letzterAuszahlungstag = DateTime.Today;
                heuteAusgezahlt = 0m;
            }

            if (heuteAusgezahlt + betrag > Tageslimit)
                throw new InvalidOperationException(
                    "Tageslimit von 500 wurde überschritten.");

            base.Auszahlen(betrag);
            heuteAusgezahlt += betrag;
        }

        public void BucheMonatlicheZinsen()
        {
            if (Kontostand <= 0)
                return;

            decimal zinsen = Kontostand * Monatszins;
            Kontostand += zinsen;

            Buche(zinsen, Buchungsart.Zinsen, "Monatliche Tagesgeld-Zinsen (0,7 %)");
        }
    }
}