using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ErsterProjekt
{
    internal class Passwortprüfer
    {
        public static void Passwortpruefer()
        {
            string passwort;
            Console.WriteLine("=== Paswort-Stärke-Prüfer ===");
            Console.WriteLine("\nBitte geben Sie das zu prüfende Passwort ein");
            try
            {
                passwort = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe" + ex.Message);
                return;
            }
            PrintStrengthReport(passwort);
        }

        public static bool HasMinLength(string text, int minLength = 8)
        {
            if (text == null)
            {
                return false;
            }

            if (text.Length >= minLength)
            {
                return true;
            }

            return false;
            
        }
        public static bool ContainsDigit(string text)
        {
           if (text == null)
            {
                return false; 
            }

            foreach (char c in text)
            {
                if (c >= '0' && c <= '9')
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ContainsUppercase(string text)
        {
            if (text == null)
            {
                return false;
            }

            foreach (char c in text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    return true;
                }
            }

            return false;
        }
        public static bool ContainsSpecialChar(string text, string special = "!@#$%^&*")
        {
            if (text == null)
            {
                return false;
            }

            foreach (char c in text)
            {
                if (special.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }
        public static int StrengthScore(string password)
        {
            int score = 0;

            if (HasMinLength(password))
            {
                score++;
            }

            if (ContainsDigit(password))
            {
                score++;
            }

            if (ContainsUppercase(password))
            {
                score++;
            }

            if (ContainsSpecialChar(password))
            {
                score++;
            }

            return score;
        }
        public static void PrintStrengthReport(string password)
        {
            Console.WriteLine("\n=== Ergebnis ===");

            Console.WriteLine("Mindestlänge (8 Zeichen): " + HasMinLength(password));
            Console.WriteLine("Enthält Zahl:            " + ContainsDigit(password));
            Console.WriteLine("Enthält Großbuchstabe:   " + ContainsUppercase(password));
            Console.WriteLine("Enthält Sonderzeichen:  " + ContainsSpecialChar(password));

            int score = StrengthScore(password);

            Console.WriteLine("\nStärke-score: " + score +"/4");

            if (score == 4)
            {
                Console.WriteLine("Passwortstärke: Stark");
            }
            else if (score == 3)
            {
                Console.WriteLine("Passwortstärke: Mittel");
            }
            else if (score == 2)
            {
                Console.WriteLine("Passwortstärke: Schwach");
            }
            else if (score == 1)
            {
                Console.WriteLine("Passwortstärke: Sehr schwach");
            }
            else
            {
                Console.WriteLine("Passwortstärke: Wahrscheinlich liegen deine Daten schon auf Nordkoreanischen Server");
            }
        }
    }
}
