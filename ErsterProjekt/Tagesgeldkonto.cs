using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Tagesgeldkonto : Bankkonto
    {
        private const decimal TAGESLIMIT = 500m; 
        private decimal auszahlungHeute = 0m;
        private DateTime letzterTag = DateTime.Today;

        public Tagesgeldkonto(string kontoinhaber, string bank = "Parkbank", string filiale = "Wegberg")
            : base(kontoinhaber, bank, filiale)
        {
        }


        public override bool Auszahlen(decimal betrag, string ziel = "==========")
        {
            if (DateTime.Today > letzterTag)
            {
                auszahlungHeute = 0m;
                letzterTag = DateTime.Today;
            }

            if (betrag <= 0)
            {
                Console.WriteLine("Ungültiger Betrag.");
                return false;
            }

            if (auszahlungHeute + betrag > TAGESLIMIT)
            {
                Console.WriteLine($"Tageslimit von {TAGESLIMIT}€ überschritten. Noch verfügbar heute: {TAGESLIMIT - auszahlungHeute:F2}€");
                return false;
            }

            if (kontostand - betrag < 0)
            {
                Console.WriteLine("Zu wenig Geld auf dem Konto.");
                return false;
            }

            kontostand -= betrag;
            auszahlungHeute += betrag;

            Console.WriteLine($"Auszahlung erfolgreich. Heute ausgezahlt: {auszahlungHeute:F2}€ / {TAGESLIMIT}€ max.");
            return true;
        }


        public void MonatlicheZinsen()
        {
            kontostand *= 1.007m;
            Console.WriteLine($"Monatliche Zinsen angewendet. Neuer Kontostand: {kontostand:F2} EUR");
        }
    }
}
