using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // Elternklasse
    internal class Person
    {
        // Attribute
        public string Name { get; }
        public int Alter { get; }

        // Konstruktor
        public Person(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }

        // Methode, um alle Infos auszugeben
        public void AlleInfosAusgeben()
        {
            Console.WriteLine($"Name: {Name}, Alter: {Alter}");
        }
    }

    // Kindklasse
    internal class Schueler : Person
    {
        // Zusätzliches Attribut
        public string Klasse { get; }

        // Konstruktor
        public Schueler(string name, int alter, string klasse) : base(name, alter)
        {
            Klasse = klasse;
        }

        // Methode, um alle Infos auszugeben (inklusive Elterninfos)
        public void AlleInfosAusgeben()
        {
            // Zuerst die Infos aus der Elternklasse ausgeben
            base.AlleInfosAusgeben();
            // Dann das zusätzliche Attribut ausgeben
            Console.WriteLine($"Klasse: {Klasse}");
        }
    }
}
