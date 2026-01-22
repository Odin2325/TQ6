namespace PersonenNahVerkehr
{
    internal class OeffentlicherNahverkehr
    {
        // Eigenschaften / Attribute
        public int MaxKapazitaet { get; set; }
        public ArtBewegung Bewegung { get; set; }
        public decimal Zuverlaessigkeit { get; set; }
        public string Linie { get; set; }
        public TimeOnly Takt { get; private set; }
        public bool Aktiv { get; set; }

        // Enum
        internal enum ArtBewegung
        {
            Gleis,
            Strasse
        }

        // Konstruktor
        public OeffentlicherNahverkehr(
            int maxKapazitaet,
            ArtBewegung bewegung,
            decimal zuverlaessigkeit,
            string linie,
            string taktString,
            bool aktiv)
        {
            MaxKapazitaet = maxKapazitaet;
            Bewegung = bewegung;
            Zuverlaessigkeit = zuverlaessigkeit;
            Linie = linie;
            Aktiv = aktiv;

            ParseTakt(taktString);
        }

        // Takt parsen (HH:mm)
        private void ParseTakt(string taktString)
        {
            if (!TimeOnly.TryParseExact(taktString, "HH:mm", out TimeOnly takt))
                throw new ArgumentException("Ungültiges Taktformat. Erwartet HH:mm");

            Takt = takt;
        }

        // Nächste Abfahrt berechnen
        public TimeOnly BerechneNaechsteAbfahrt(TimeOnly letzteAbfahrt)
        {
            return TimeOnly.FromTimeSpan(
                letzteAbfahrt.ToTimeSpan() + Takt.ToTimeSpan()
            );
        }

        // Methoden / Funktionen
        public void PersonenBefoerdern()
        {
            if (!Aktiv)
                return;
        }

        public bool LeerFahrt()
        {
            return false;
        }

        public void Fahren()
        {
            if (!Aktiv)
                return;
        }

        public void Halten()
        {

        }

        public bool Wartung()
        {
            return Zuverlaessigkeit < 0.7m;
        }
    }

}
