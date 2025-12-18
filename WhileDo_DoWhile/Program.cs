namespace WhileDo_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WHILE DO SCHLEIFE
            int summe = 0;
            int zaehler = 1;
            string resultat = "0";

            while (zaehler <= 50)
            {
                summe += zaehler;
                resultat += " + " + zaehler;
                zaehler++;
            }

            Console.WriteLine(resultat + " = " + summe);

            int verdoppelteSumme = summe * 2;
            Console.WriteLine("Summe * 2 = " + verdoppelteSumme);



            // DO WHILE SCHLEIFE
            int summe2 = 0;
            int zaehler2 = 1;
            string resultat2 = "0";

            do
            {
                summe2 += zaehler2;
                resultat2 += " + " + zaehler2;
                zaehler2++;
            }
            while (zaehler2 <= 50);

            Console.WriteLine(resultat2 + " = " + summe2);

            int verdoppelteSumme2 = summe2 * 2;
            Console.WriteLine("Summe * 2 = " + verdoppelteSumme2);
        }
    }
}