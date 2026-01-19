using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Textstatistik
    {
        public static void Textstat()
        {
            Console.WriteLine("=== Text Statistik ===");
            Console.WriteLine("\nBitte gebe den Text ein:");
            string text = Console.ReadLine();

            PrintTextStats(text);
        }

        static int CountVowels(string text, string vowels = "aeiouAEIOU")
        {
            int count = 0;

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
                
            }
            return count;
        }

        static int CountLetters(string text, bool countSpaces = false)
        {
            int count = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
                else if (countSpaces && c == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        static int CountWords(string text)
        {
            int count = 0;
            bool Wort = false;

            foreach (char c in text)
            {
                if (c != ' ')
                {
                    if (!Wort)
                    {
                        count++;
                        Wort = true;
                    }
                }
                else
                {
                        Wort = false;
                }
            }
            return count;
        }

        static void PrintTextStats(string text)
        {
            int letters = CountLetters(text);
            int vowels = CountVowels(text);
            int words = CountWords(text);

            Console.WriteLine("Buchstaben: " + letters);
            Console.WriteLine("Vokale: " + vowels);
            Console.WriteLine("Wörter: " + words);
        }

    }
}
