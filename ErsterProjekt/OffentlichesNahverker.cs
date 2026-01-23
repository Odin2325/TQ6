using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class OffentlichesNahverker
    {
        public enum artBewegung
        {
            Gleis,
            Strasse
        }
        //Eigenschaften/Attribute
       
        int maxKapazitaet;
        
        decimal zuverlaessigkeit;
        string linie;
        TimeOnly takt;
        bool aktiv;
        artBewegung art;

        public OffentlichesNahverker(int maxKapazitaet,


             
            decimal zuverlaessigkeit,
            string linie,
            TimeOnly takt,
            bool aktiv)
            {
            this.maxKapazitaet = maxKapazitaet;

            
            this.zuverlaessigkeit = zuverlaessigkeit;
            this.linie = linie;
            this.takt = takt; 
            this.aktiv = aktiv; 
                }





    //Methoden/Funktionen
    /*
     * void PersonenBefoerdern()
     * bool LeerFahrt()
     * void Fahren()
     * void Halten()
     * bool Wartung()
     */



    public void PersonenBefoerdern()
        {
            Console.WriteLine($"{linie} befördert Personen.");
        }
        public bool LeerFahrt()
        {
            maxKapazitaet = 0;
            return true;
        }
                
        public void Fahren()
        {
            Console.WriteLine($"{linie} fährt los.");
        }
        public void Halten()
        {

            Console.WriteLine($"{linie} hält an einer Haltestelle.");
        }
        public bool Wartung()
        {
           aktiv =!aktiv;
            return true;
        }

    } 
}
    



