using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class ZahlenWerkzeug
    {
        public static bool IsPrime(int n)
        {
            if (n == 0)
            {
                return false;
            }

            n = Math.Abs(n);

            if (n == 1)
            {
                return true;
            }

            for (int zaehler = 2; zaehler < n; zaehler++)
            {
                if (n % zaehler == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //gerade zahlen => immer positiv am ende
        //ungerade zahlen => negative am ende
        //5! => 5*4*3*2*1
        //20! => 20*19*18..*2*1
        public static long Factorial(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            long resultat = 1;

            bool istNegative = false;

            if (n < 0)
            {
                n = Math.Abs(n);
                istNegative = true;
            }

            for (int zahl = n; zahl > 1; zahl--)
            {
                resultat *= zahl;
            }

            if (n % 2 != 0)
            {
                resultat *= -1;
            }

            return resultat;
        }


        public static void PrintPrimesInRange(int start, int end)
        {
            string resultat = $"Die Primzahlen im Bereich von {start} bis {end} sind: ";
            List<int> primZahlen = PrimesInRange(start, end).Item2;
            foreach (int zahl in primZahlen)
            {
                resultat += $"{zahl} ";
            }
            Console.WriteLine(resultat);
        }

        private static (int, List<int>) PrimesInRange(int start, int end)
        {
            List<int> primZahlen = new List<int>();

            for (int i = start; i < end; i++)
            {
                if (IsPrime(i))
                {
                    primZahlen.Add(i);
                }
            }

            return (primZahlen.Count, primZahlen);
        }

        public static int CountPrimesInRange(int start, int end)
        {
            return PrimesInRange(start, end).Item1;
        }

        public static int SumOfDigits(int n)
        {
            int querSumme = 0;

            string zahlInTextForm = "" + n;

            for (int i = 0; i < zahlInTextForm.Length; i++)
            {
                querSumme += int.Parse(zahlInTextForm.Substring(i, 1));
            }

            return querSumme;
        }
    }
}
