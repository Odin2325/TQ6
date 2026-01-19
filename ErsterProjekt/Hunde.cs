using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class Hunde
    {
        //Attribute

        public string rasse;
        public string farbe;
        public string besitzer;
        public string gewicht;


        // Konstruktor

        public  Hunde(string rasse, string farbe, string besitzer, string gewicht)
        {
            this.rasse = rasse;
            this.farbe = farbe;
            this.besitzer = besitzer;
            this.gewicht = gewicht;
        }
        //methode laufen

        public void Laufen()
        {
            Console.WriteLine($" der hund{rasse} läuft schnell in den Garten");
        }
        //methode bellen
        public void Bellen() 
        {
            Console.WriteLine($" der hund mit der farbe{ farbe} Bellen sehr laut");


        }

        // methode sitzen
        public void Sitzen() 
        
        {

            Console.WriteLine($" der Hunde mit gewicht{gewicht} sitzt auf dem Stuhl");
       
        
        }
         
        //methode rollen
        public void Rollen()
        {
            Console.WriteLine($"der hund mit besitzer{besitzer} rollt sehr schnell");
        }
    }
}
