using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    internal class OeffentlichesNahverkehr
    {
        // Enum
        public enum ArtBewegung
        {
            Gleis,
            Strasse
        }

        // Eigenschaften (Attribute)
        public int MaxKapazitaet { get; }
        public ArtBewegung Bewegung { get;}
        public decimal Zuverlaessigkeit { get;}
        public string Linie { get;}
        public TimeOnly Takt { get;}
        public bool Aktiv { get;}

        // Konstruktor
        public OeffentlichesNahverkehr(int maxKapazitaet, ArtBewegung bewegung, string linie, TimeOnly takt)
        {
            MaxKapazitaet = maxKapazitaet;
            Bewegung = bewegung;
            Linie = linie;
            Takt = takt;
            Aktiv = true;
            Zuverlaessigkeit = 0.95m;
        }

        // Methoden (je 1 Zeile!)
        public void PersonenBefoerdern() => Console.WriteLine("Personen werden befördert.");
        public bool LeerFahrt() => false;
        public void Fahren() => Console.WriteLine("Fahrzeug fährt.");
        public void Halten() => Console.WriteLine("Fahrzeug hält.");
        public bool Wartung() => true;
    }
}

