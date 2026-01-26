using System;
using System.Collections.Generic;
using System.Text;

namespace ErsterProjekt
{
    class Person
    {
        // Attribute
        protected string Name;
        protected int Alter;

        // Konstruktor
        public Person(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }

        // Methode zur Ausgabe
        public virtual void InformationenAusgeben()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Alter: " + Alter);
        }
    }

    class Schueler : Person
    {
        // Zusätzliches Attribut
        private string Klasse;

        // Eigener Konstruktor
        public Schueler(string name, int alter, string klasse)
            : base(name, alter)   // Aufruf des Person-Konstruktors
        {
            Klasse = klasse;
        }

        // Methode zur Ausgabe (inkl. Elternklasse)
        public override void InformationenAusgeben()
        {
            base.InformationenAusgeben(); // Ausgabe von Name & Alter
            Console.WriteLine("Klasse: " + Klasse);
        }
    }
}
