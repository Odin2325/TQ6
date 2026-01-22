namespace ErsterProjekt
{
    internal class Program
    {
        static void Main()
        {

            Bank meineBank = new Bank("Super Bank", "Muenchen1", "Muenchen", "Leopold Str.11");
            meineBank.BankMenueOeffnen();
            Console.WriteLine("Programm beendet. Danke für die Nutzung der Bank.");


            //Bankkonto aufrufen

            //Bankkonto meinBankkonto = new Bankkonto("hilmar");

            //Bankkonto nicoKonto = new Bankkonto("Nicolas Arevalo Hoelscher");

            //Console.WriteLine("Geben Sie bitte Ihre pin ein:");
            //string pin = Console.ReadLine();
            //meinBankkonto.Einzahlen(200, pin);
            //meinBankkonto.Auszahlen(100.50m, pin);
            //meinBankkonto.Kontoauszug(pin);                         
            //meinBankkonto.Kontodetails();    

            //Bank meineBank = new Bank("SuperBank", "Muenchen-Zentrum", "Muenchen","Maximilianstraße 8");

            //meineBank.KontoErstellen("Nico");

            //meineBank.KontoErstellen("Saba");

            //meineBank.KontoErstellen("Hannes");

            //meineBank.KontoErstellen("Ron");

            //meineBank.KontoErstellen("Vache");

            //meineBank.KontoErstellen("Hilmar");

            //meineBank.BankDetailsAusgeben();



            //superBank.KontoErstellen("Nicolas Arevalo Hoelscher");
            //superBank.KontoErstellen("Hilmar");
            //superBank.KontoErstellen("Hannes");
            //superBank.KontoErstellen("Ron");
            //superBank.KontoErstellen("Saba");
            //superBank.KontoErstellen("Vache");
            //superBank.KontoErstellen("Sascha");
            //superBank.KontoErstellen("Bobby");

            //Console.WriteLine("Geben Sie bitte Ihre IBAN ein:");
            //string ibanEingabe = Console.ReadLine();
            //Bankkonto meinKonto = superBank.KontoFindenDurchIBAN(ibanEingabe);
            //meinKonto.Einzahlen(100m);
            //meinKonto.Auszahlen(73m);
            //meinKonto.Einzahlen(97m);
            //meinKonto.Einzahlen(2000m);
            //Console.WriteLine("Geben Sie fuer die Ueberweisung einen Ziel IBAN ein:");
            //string zielIban = Console.ReadLine();
            //Console.WriteLine("Geben Sie den Betrag den Sie Ueberweisen moechten ein:");
            //decimal betrag = decimal.Parse(Console.ReadLine());
            //superBank.UeberweisungDurchfuehren(ibanEingabe, zielIban, betrag);
            //meinKonto.Kontoauszug();
            //superBank.KontoFindenDurchIBAN(zielIban).Kontoauszug();

            //Bankkonto nicoKonto = new Bankkonto("Nicolas Arevalo Hoelscher");
            //nicoKonto.Kontodetails();
            //Console.WriteLine("Geben Sie Ihr pin bitte ein:");
            //string pin = Console.ReadLine();
            //nicoKonto.Einzahlen(100m,pin);
            //nicoKonto.Auszahlen(73m, pin);
            //nicoKonto.Einzahlen(97m, pin);
            //nicoKonto.Einzahlen(2000m, pin);
            //nicoKonto.Kontoauszug(pin);





            // Hund-Objekt erstellen (Konstruktor aufrufen)

            //Hund meinHund = new Hund("Labrador", "braun", "Max", 28.5);           

            // 2️⃣ Methoden aufrufen
            //meinHund.Bellen();
            //meinHund.Laufen(30);
            //meinHund.Sitzen();
            //meinHund.Rollen();

            //Console.ReadKey();




        }
    }
}
