//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MicrosoftLearn
//{
//    internal class ArraysMethoden
//    {
//        static void Main()
//        {
            //string[] pallets = ["B14", "A11", "B12", "A13"];

            //Console.WriteLine("Sorted...");
            //Array.Sort(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}


            //string[] pallets = ["B14", "A11", "B12", "A13"];

            //Console.WriteLine("Sorted...");
            //Array.Sort(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Reversed...");
            //Array.Reverse(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}



            //string[] pallets = ["B14", "A11", "B12", "A13"];
            //Console.WriteLine("");

            //Array.Clear(pallets, 0, 2);
            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}



            //string[] pallets = ["B14", "A11", "B12", "A13"];
            //Console.WriteLine("");

            //Console.WriteLine($"Before: {pallets[0]}");
            //Array.Clear(pallets, 0, 2);
            //Console.WriteLine($"After: {pallets[0]}");

            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}



            //string[] pallets = ["B14", "A11", "B12", "A13"];
            //Console.WriteLine("");

            //Array.Clear(pallets, 0, 2);
            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Array.Resize(ref pallets, 6);
            //Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            //pallets[4] = "C01";
            //pallets[5] = "C02";

            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}



            //string[] pallets = ["B14", "A11", "B12", "A13"];
            //Console.WriteLine("");

            //Array.Clear(pallets, 0, 2);
            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Array.Resize(ref pallets, 6);
            //Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            //pallets[4] = "C01";
            //pallets[5] = "C02";

            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Array.Resize(ref pallets, 3);
            //Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}


            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);
            //string result = new string(valueArray);
            //Console.WriteLine(result);


            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);
            //// string result = new string(valueArray);
            //string result = String.Join(",", valueArray);
            //Console.WriteLine(result);



            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);
            //// string result = new string(valueArray);
            //string result = String.Join(",", valueArray);
            //Console.WriteLine(result);

            //string[] items = result.Split(',');
            //foreach (string item in items)
            //{
            //    Console.WriteLine(item);
            //}



            //Übung Reihenfolge umkehren(Einheit5)
            //string pangram = "The quick brown fox jumps over the lazy dog";
            //Schreiben Sie den Code, der erforderlich ist, um die Buchstaben jedes Worts an Ort und Stelle umzukehren und das Ergebnis anzuzeigen.

            //Es geht also nicht darum, einfach jeden Buchstaben in der Variablen pangram umzukehren. 
            //Stattdessen müssen Sie nur die Buchstaben in jedem Wort umkehren, aber das umgekehrte Wort an seiner 
            //ursprünglichen Position in der Nachricht drucken.Ihr Code sollte die folgende Ausgabe generieren:

            //Output
            //ehT kciuq nworb xof spmuj revo eht yzal god

            //Wichtig: Diese Herausforderung ist besonders schwierig. Sie müssen viele der Konzepte kombinieren, 
            //die Sie in dieser Übung kennengelernt haben, einschließlich der Verwendung von Split(), ToCharArray(), 
            //Array.Reverse() und String.Join().Außerdem müssen Sie mehrere Arrays und mindestens eine Iterationsanweisung erstellen.


//           string pangram = "The quick brown fox jumps over the lazy dog";

//            string[] words = pangram.Split(' ');


//        }
//    }
//}
