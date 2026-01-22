//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Reflection;
//using System.Text;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace MicrosoftLearn
//{
//    internal class Arrays_foreach
//    {
//        static void Main()
//        {
//            /*
//            string[] fraudulentOrderIDs = new string[3];

//            fraudulentOrderIDs[0] = "A123";
//            fraudulentOrderIDs[1] = "B456";
//            fraudulentOrderIDs[2] = "C789";
//            // fraudulentOrderIDs[3] = "D000";
//            */

//            //string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

//            //Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//            //Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
//            //Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//            //fraudulentOrderIDs[0] = "F000";

//            //Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");




//            //string[] names = { "Rowena", "Robin", "Bao" };
//            //foreach (string name in names)
//            //{
//            //    Console.WriteLine(name);
//            //}




//            //int[] inventory = { 200, 450, 700, 175, 250 };
//            //int sum = 0;
//            //foreach (int items in inventory)
//            //{
//            //    sum += items;
//            //}

//            //Console.WriteLine($"We have {sum} items in inventory.");




//            //int[] inventory = { 200, 450, 700, 175, 250 };
//            //int sum = 0;
//            //int bin = 0;
//            //foreach (int items in inventory)
//            //{
//            //    sum += items;
//            //    bin++;
//            //    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
//            //}
//            //Console.WriteLine($"We have {sum} items in inventory.");



//            //Einheit 4 Aufgaebe:
//            //Programmierherausforderung: Melden zu untersuchender Bestell-IDs. Ihr Team hat ein Muster ermittelt. Bestellungen,
//            //die mit dem Buchstaben „B“ beginnen, wiesen das 25 - fache der normalen Rate an Betrugsfällen auf.
//            //Sie schreiben neuen Code, der die Auftrags-IDs neuer Bestellungen ausgibt, deren Auftrags-ID mit dem Buchstaben „B“ beginnt.
//            //Dieser wird dann vom Betrugsbekämpfungsteam genutzt, um weitere Untersuchungen anzustellen.Deklarieren Sie ein Array,
//            //und initialisieren Sie es mit den folgenden Elementen: B123; C234; A345; C15; B177; G3003 C235; B179; Diese Werte repräsentieren
//            //die Daten der betrügerischen Auftrags-ID, die Ihre Anwendung verwendet. Erstellen Sie eine foreach-Anweisung, um die einzelnen
//            //Elemente Ihres Arrays zu durchlaufen. Melden Sie die Bestell-IDs, die mit dem Buchstaben „B“ beginnen.Sie müssen jedes Element
//            //des Arrays auswerten.Melden Sie die potenziell betrügerischen Bestell-IDs, indem Sie die Bestellungen ermitteln, die mit dem
//            //Buchstaben „B“ beginnen.Verwenden Sie die String.StartsWith() - Methode, um festzulegen, ob ein Element mit dem Buchstaben „B“
//            //beginnen soll. Folgenden finden Sie ein einfaches Beispiel für die Verwendung der String.StartsWith()
//            //Im  - Methode, das Sie an Ihren Code
//            //anpassen können: string name = "Bob"; if (name.StartsWith("B")) { Console.WriteLine("The name starts with 'B'!"); }
//            //Ihre Ausgabe sollte der folgenden entsprechen: Output: B123 B177 B179 !Tipp: Wenn Sie jedes Element in 
//            //Ihrem Array durchlaufen, benötigen Sie eine if Anweisung.Die if Anweisung muss eine Methode für die Zeichenfolgenklasse
//            //verwenden, um festzustellen, ob eine Zeichenfolge mit einem bestimmten Buchstaben beginnt.Wenn Sie sich nicht sicher sind,
//            //wie Sie eine if-Anweisung verwenden, sehen Sie sich das Modul „Verwenden der ‚if-elseif -else‘-Anweisung in C# zum
//            //Hinzufügen von Entscheidungslogik zu Code“ an.

//            ////Programmstart:
//            //string[] bestellIds = [ "B123","C234","A345","C15","B177","G3003","C235","B179" ];

//            //// foreach-Schleife: Jedes Element wird einzeln geprüft
//            //foreach (string id in bestellIds)
//            //{
//            //    if (id.StartsWith("B"))
//            //    {
//            //        Console.WriteLine(id);
//            //    }
//            //}








//        }

//    }
//}
