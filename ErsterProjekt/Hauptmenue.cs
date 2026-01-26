using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ErsterProjekt
{
    internal class Hauptmenue
    {
        
        public static void Mainmenue() 
        {
            Console.WriteLine("Willkommen in der TQ6");
            Console.WriteLine("\nHier findest du alle Programme die wir entwickelt haben.");
            Console.WriteLine("\nWähle ein Programm aus:");
            Console.WriteLine("\n1.Taschenrechner");
            Console.WriteLine("\n2.Passwort-Stärke-Prüfer");
            Console.WriteLine("\n3.Text Statistik");
            Console.WriteLine("\n4.Zahlen-Werkzeuge");
            Console.WriteLine("\n5.Bankkonto");
            Console.WriteLine("\n6.Verkehr");
            Console.WriteLine("\n7.Schule");
            Console.WriteLine("\nAuswahl:");

            int wahl;

            try
            {
                wahl = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nUngültige Eingabe: " + ex.Message);
                return;
            }
            switch (wahl)
            {
                case 1:
                    Rechnermenue();
                    break;
                case 2:
                    Passwortprüfer.Passwortpruefer();
                    break;
                case 3:
                    Textstatistik.Textstat();
                    break;
                case 4:
                    Zahlen_Werkzeug.ZahlenWerk();
                    break;
                case 5:
                    //Bankkonto HannesBankkonto = new Bankkonto("Hannes", "Parkbank", "Wegberg");
                    //HannesBankkonto.Kontodetails();
                    //Bankmenue();
                    Bank Parkbank = new Bank("Parkbank", "HS4", "Wegberg", "Am Stadtpark");
                    Parkbank.BankMenueOeffnen();
                    break;
                case 6:
                    Dictionary<int, List<int>> zeitplan = new Dictionary<int, List<int>>();
                    zeitplan.Add(0, new List<int>() { 20, 40 });
                    zeitplan.Add(7, new List<int>() { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 });
                    zeitplan.Add(2, new List<int>() { 20, 40 });
                    zeitplan.Add(13, new List<int>() { 20, 40 });

                    Bus meinBus = new Bus(45, 0.95, 101, zeitplan);

                    meinBus.Fahren();

                    meinBus.Halten();
                    break;
                case 7:
                    Schueler schueler = new Schueler("Anna", 16, "10B");
                    schueler.InformationenAusgeben();
                    break;

                default:
                    Console.WriteLine("Coming Soon!");
                    break;
            }
        
        }
        public static void Rechnermenue()
        {
            Console.WriteLine("=== Taschenrechner ===");
            Console.WriteLine("\nWillkommen beim Taschenrechner");
            Console.WriteLine("\nWas möchtest du machen?");
            Console.WriteLine("\n1. Addieren");
            Console.WriteLine("\n2. Subtrahieren");
            Console.WriteLine("\n3. Multiplizieren");
            Console.WriteLine("\n4. Dividieren");
            Console.WriteLine("\n5. Exponenten");
            Console.WriteLine("\nAuswahl:");

            int wahl;

            try
            {
                wahl = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe:" + ex.Message);
                return;
            }
            switch (wahl)
            {
                case 1:
                    Taschenrechner.Addieren();
                    break;
                case 2:
                    Taschenrechner.Subtrahieren();
                    break;
                case 3:
                    Taschenrechner.Multiplizieren();
                    break;
                case 4:
                    Taschenrechner.Dividieren();
                    break;
                case 5:
                    Taschenrechner.Exponent();
                    break;
                default:
                    Console.WriteLine("Coming Soon");
                    break;
            }

        }
    }
}
