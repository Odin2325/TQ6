using ErsterProjekt;
using System;
using System.Collections.Generic;

namespace ErsterProjekt
{
    internal class Schule
    {
        private List<Person> schueler;//Attribute

        public Schule( )
        {
            schueler = new List<Person>();//konstrukture
        }

        public void AddSchueler(Person person)
        {
            schueler.Add(person);
        }

        // Methode, die alle Informationen ausgibt
        public void SchuelerDetails()
        {
            foreach (var s in schueler)
            {
                Console.WriteLine($"{s.GetName()} ist {s.GetAlter()} Jahre alt.");
            }
        }
    }
}

