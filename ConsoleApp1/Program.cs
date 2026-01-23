namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {

            // Objekt der Kindklasse Schueler erstellen
            Schueler schueler = new Schueler("Anna", 16, "10B");

            // Alle Informationen ausgeben
            schueler.AlleInfosAusgeben();

            // Damit das Konsolenfenster offen bleibt (optional)
            Console.ReadKey();



        }
    }
}
