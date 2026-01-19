using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Bankkonto
    {
        //Attribute
        private decimal kontostand;
        //                      DE              89              37040          04405        3201300
        private string iban;//country code - check digit - bank id code - branche code - kontonummer
        private string kontonummer;
        private string kontoinhaber;
        private string bank;
        private string filiale;
        //    PSTB       DE                MU           MU2       => PSTBDEMUMU2
        //Bank code - laendercode - standort stadt - filiale
        private string bic;
        private string pin;
        private static int zaehler = 0;

        //Konstruktor
        public Bankkonto(string kontoinhaber, string bank="SuperBank", string filiale="Muenchen")
        {
            this.kontoinhaber = kontoinhaber;
            this.bank = bank;
            this.filiale = filiale;
            kontostand = 0;
            pin = PinErstellen();
            bic = BicErstellen();
            kontonummer = KontonummerErstellen();
            this.iban = IBANErstellen();   
            Console.WriteLine($"Das KN von: {kontoinhaber} ist {kontonummer}.");
            zaehler++;
            //Pin ueberpruefen methode: Console.WriteLine(pin);
            //iban
            //kontonummer
            //bic
            //Anforderungen fuer BIC:
            //Bic soll zuffaelig 4 zeichen erstellen und abspeichern, dann DE abspeichern,
            //dann 2 zuffaelige buchstaben, dann erste 2 buchstaben
            //von filiale und eine zuffaelige zahl zwischen 0-9
        }

        //Methoden
        private string BicErstellen()
        {
            Random random = new Random();
            string neuerBic = "";
            for (int i = 0; i < 4; i++)  // 4 zufällige Buchstaben
            {
                char buchstabe = (char)random.Next('A', 'Z' + 1);
                neuerBic += buchstabe;
            }


            neuerBic += "DE"; // DE hinzufügen


            for (int i = 0; i < 2; i++) // 2 zufällige Buchstaben
            {
                char buchstabe = (char)random.Next('A', 'Z' + 1);
                neuerBic += buchstabe;
            }


            string filialeKurz = filiale.Substring(0, 2).ToUpper(); //  Die ersten 2 Buchstaben der Filiale
            neuerBic += filialeKurz;


            neuerBic += random.Next(0, 10); // Eine Zufällige Zahl hinzufügen

            return neuerBic;
        }
        private string KontonummerErstellen()
        {
            string kontonummer = "";
            int zaehlerLaenge = (""+zaehler).Length;

            for(int i = 0; i < 10-zaehlerLaenge; i++)
            {
                kontonummer += 0;
            }
            kontonummer += zaehler;

            return kontonummer;
        }

        private string PinErstellen()
        {
            Random random = new Random();
            string neuerPin = "";

            for(int i = 0; i< 4; i++)
            {
                neuerPin += random.Next(0, 10);
            }
            return neuerPin;
        }

        private string IBANErstellen()
        {
            Random random = new Random();
            string IBAN = "";
            string laendercode = "DE";
            string pruefsumme = "";
            string BLZ = "";
            for (int i = 0; i < 2; i++)
            {
                pruefsumme += random.Next(0, 10);
            }
            for (int i = 0; i < 6; i++)
            {
                BLZ += random.Next(0, 10);
            }
            IBAN += laendercode + pruefsumme + BLZ + kontonummer;
            return IBAN;
        }




    }
}
