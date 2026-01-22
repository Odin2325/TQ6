//namespace ErsterProjekt
//{
//    internal class Auto
//    {
//        //Attribute
//        string farbe;
//        string modell;
//        string hersteller;
//        int ps;
//        public int maxGeschwindigkeit;
//        int aktuelleGeschwindigkeit;

//        //Konstruktor -> Wie auto erstellt wird
//        public Auto(string farbe, string modell, string marke, int ps, int maxGeschwindigkeit)
//        {
//            this.farbe = farbe;
//            this.modell = modell;
//            hersteller = marke;
//            this.ps = ps;
//            this.maxGeschwindigkeit = maxGeschwindigkeit;
//            aktuelleGeschwindigkeit = 0;
//        }

//        //Methoden
//        public void Fahren(int neueGeschwindigkeit)
//        {
//            for (int i = aktuelleGeschwindigkeit; i <= neueGeschwindigkeit; i += 10)
//            {
//                aktuelleGeschwindigkeit = i;
//                Console.WriteLine($"Wir fahren schneller. Aktuelle Geschwindigkeit: {aktuelleGeschwindigkeit}");
//                if (aktuelleGeschwindigkeit >= maxGeschwindigkeit)
//                {
//                    Console.WriteLine("Max Geschwindigkeit erreicht.");
//                    aktuelleGeschwindigkeit = maxGeschwindigkeit;
//                    return;
//                }
//            }
//        }

//        public void Bremsen(int distanzZuObstacle)
//        {

//        }

//        public void Parken()
//        {

//        }
//    }
//}

namespace ErsterProjekt
{
    internal class Hund
    {
        // Attribute
        string rasse;
        string farbe;
        string besitzer;
        double gewicht;
        bool sitzt;

        // Konstruktor -> Wie Hund erstellt wird
        public Hund(string rasse, string farbe, string besitzer, double gewicht)
        {
            this.rasse = rasse;
            this.farbe = farbe;
            this.besitzer = besitzer;
            this.gewicht = gewicht;
            sitzt = false;
            //Zum testen:Console.WriteLine(farbe);
        }

        // Methoden
        public void Laufen(int meter)
        {
            Console.WriteLine($"{rasse} läuft {meter} Meter.");
        }

        public void Bellen()
        {
            Console.WriteLine($"{rasse} sagt: Wau! Wau!");
        }

        public void Sitzen()
        {
            sitzt = true;
            Console.WriteLine($"{rasse} setzt sich hin.");
        }

        public void Rollen()
        {
            if (sitzt)
            {
                Console.WriteLine($"{rasse} rollt über den Boden.");
            }
            else
            {
                Console.WriteLine($"{rasse} muss sich erst hinlegen, bevor er rollen kann.");
            }
        }
    }
}

