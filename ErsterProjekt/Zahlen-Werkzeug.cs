using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ErsterProjekt
{
    internal class Zahlen_Werkzeug
    {
        public static void ZahlenWerk()
        {
            int start = 0;
            int end = 0;
            Console.WriteLine("=== Zahlen-Werkzeuge ===");
            Console.WriteLine("\nWas möchtest du tun?");
            Console.WriteLine("\n1. Eine Primzahlprüfung");
            Console.WriteLine("\n2. Fakultät");
            Console.WriteLine("\n3. Ein Bereich auf Primzahlenprüfen");
            Console.WriteLine("\n4. Zählt Primzahlen in einen Bereich");
            Console.WriteLine("\n5. Quersummenberechnen");

            Console.WriteLine("\nDeine Wahl: ");
            int wahl = 0;
            try
            {
                wahl = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe: " + ex.Message);
            }

            switch (wahl)
            {
                case 1:
                    Console.Write("Zahl für Primzahlprüfung eingeben: ");
                    int primeZahl = 0;
                    try
                    {
                        primeZahl = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ungültige Eingabe: " + ex.Message);
                    }
                    bool istPrim = IsPrime(primeZahl);
                    Console.WriteLine(istPrim ? "Die Zahl ist eine Primzahl." : "Die Zahl ist keine Primzahl.");
                    break;
                case 2:
                    Console.Write("Zahl für Fakultät eingeben:");
                    int fZahl = 0;
                    try
                    {
                        fZahl = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ungültige Eingabe: " + ex.Message);
                    }
                    long fakultaet = Factorial(fZahl);
                    if
                        (fakultaet == -1)
                        Console.WriteLine("Ungültige Eingabe (negative Zahl)");
                    else
                        Console.WriteLine("Fakultät: " + fakultaet);
                    break;
                case 3:
                    Console.WriteLine("Startwert eingeben: ");
                    try
                    {
                        start = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ungültige Eingabe " + ex.Message);
                    }
                    Console.WriteLine("Endwert eingeben: ");
                    try
                    {
                        end = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ungültige Eingabe " + ex.Message);
                    }
                    Console.WriteLine("Primzahlen im Beriech:");
                    PrintPrimesInRange(start, end);
                    break;

                case 4:
                    
                    Console.WriteLine("Startwert eingeben: ");
                    try
                    {
                        start = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ungültige Eingabe " + ex.Message);
                    }
                    Console.WriteLine("Endwert eingeben: ");
                    try
                    {
                        end = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ungültige Eingabe " + ex.Message);
                    }
                    int anzahl = CountPrimesInRange(start, end);
                    Console.WriteLine("Anzahl Primezahl: " + anzahl);
                    break;

                case 5:
                    Console.Write("Zahl für Quersumme eingeben: ");
                    int qzahl = 0;
                    try
                    {
                        qzahl = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ungültige Eingabe " + ex.Message);
                    }
                    int quersumme = SumOfDigits(qzahl);
                    Console.WriteLine("Quersumme: " + quersumme);
                    break;


                default:

                    Console.WriteLine("Ungültige Auswahl!");
                    break;

            }
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0) return false;
            return true;
        }

        public static long Factorial(int n)
        {
            if (n < 0) return -1;

            long result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;

            return result;
        }
        public static void PrintPrimesInRange(int start, int end)
        {
            for (int i = start; i <= end; i++)
                if (IsPrime(i))
                    Console.WriteLine(i);
        }
        public static int CountPrimesInRange(int start, int end)
        {
            int count = 0;
            for (int i = start; i <= end; i++)
                if (IsPrime(i))
                    count++;
            return count;
        }
        public static int SumOfDigits(int n)
        {
            n = Math.Abs(n); 
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;        
            }

            return sum;
        }
    }
}
