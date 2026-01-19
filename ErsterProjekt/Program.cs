namespace ErsterProjekt
{
    internal class Program
    {
        static void Main()
        {

            Bankkonto nicoKonto = new Bankkonto("Nicolas Arevalo Hoelscher");
            Bankkonto sabaKonto = new Bankkonto("Saba Farhan", filiale: "Konstanz");
            Bankkonto vacheKonto = new Bankkonto("Vache Aghajanyan", filiale: "Hamburg");
            Bankkonto hannesKonto = new Bankkonto("Hannes Meyer", filiale: "Berlin");
            Bankkonto saschaKonto = new Bankkonto("Sascha Schilling");
        }
    }
}