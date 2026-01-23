using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace ErsterProjekt
{
    // Elternklasse mit dem Namen Person
    internal class Person
    {
        // Attribute: Die Klasse soll zwei Attribute besitzen
        public string Name;
        public int Alter;
            
        // Die Klasse soll einen Konstruktor haben, der beide Werte entgegennimmt

        //Der Konstruktor soll die übergebenen Werte in den Attributen speichern
        public Person(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }

        // Die Klasse soll eine Methode besitzen, die alle Informationen ausgibt
        public void AlleInfosAusgeben()
        {
            Console.WriteLine($"Name: {Name}\nAlter: {Alter}");
        }
    }

    // Kindklasse erstellen
    internal class Schueler : Person
    {
        // Zusätzliches Attribut
        public string Klasse { get; }

        // Die Klasse soll einen eigenen Konstruktor haben, der Name,Alter und Klasse entgegennimmt
        public Schueler(string name, int alter, string klasse) : base(name, alter)
        {
            Klasse = klasse;
        }

        // Methode, um alle Infos auszugeben (inklusive Infos aus der Elternklasse)
        public void AlleInfosAusgeben()
        {
            // Zuerst die Infos aus der Elternklasse ausgeben
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Alter: {Alter}");
            // Dann das zusätzliche Attribut ausgeben
            Console.WriteLine($"Klasse: {Klasse}");
        }
    }
}
