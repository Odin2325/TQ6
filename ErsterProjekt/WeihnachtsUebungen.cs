//namespace ErsterProjekt
//{
//    internal class WeihnachtsUebungen
//    {
//        static void Main()
//        {

//Übung 1: Gerade oder Ungerade(if / else)
//Aufgabe
//Schreibe ein C#-Programm, das:
//1.
//Den Benutzer nach einer ganzen Zahl fragt
//2.
//Überprüft, ob die Zahl gerade oder ungerade ist
//3.
//Das Ergebnis ausgibt


//Console.WriteLine("Bitte eine ganze Zahl eingeben und Enter drücken:");

//string eingabe = Console.ReadLine();

//if (int.TryParse(eingabe, out int zahl))//Hier überprüfe ich ob es eine ganze Zahl ist,
//                                        //wenn ja eingabe als int in die variable zahl,falls nicht sofort nach unten!
//{
//    if (zahl % 2 == 0)//Hier überprüfe ich ob der Rest 0 ist!
//    {
//        Console.WriteLine("Die Zahl ist gerade!");
//    }
//    else
//    {
//        Console.WriteLine("Die Zahl ist ungerade!");
//    }
//}

//else
//{
//    Console.WriteLine("Das ist keine ganze Zahl!");
//}


//Übung 2: Wochentag auswählen(switch)
//Aufgabe
//Schreibe ein Programm, das:
//1.
//Eine Zahl von 1 bis 7 einliest
//2.
//Den passenden Wochentag ausgibt
//3.
//Bei ungültiger Eingabe eine Fehlermeldung anzeigt



//Console.WriteLine("Bitte eine Zahl von 1 bis 7 eingeben und Enter drücken:");

//string eingabe = Console.ReadLine();

//if (int.TryParse(eingabe, out int tag)) //Hier überprüfe ich ob es eine ganze Zahl ist,
//wenn ja eingabe als int in die variable tag,falls nicht sofort nach unten!

//{
//    switch (tag)

//    {   //Abfrage der einzelnen Fälle
//        case 1:
//            Console.WriteLine("Montag!");
//            break;
//        case 2:
//            Console.WriteLine("Dienstag!");
//            break;
//        case 3:
//            Console.WriteLine("Mittwoch!");
//            break;
//        case 4:
//            Console.WriteLine("Donnerstag!");
//            break;
//        case 5:
//            Console.WriteLine("freitag!");
//            break;
//        case 6:
//            Console.WriteLine("Samstag!");
//            break;
//        case 7:
//            Console.WriteLine("Sonntag!");
//            break;
//        default:
//            Console.WriteLine("Bitte eine Zahl zwischen 1 und 7 eingeben!");
//            break;
//    }
//}

//else
//{
//    Console.WriteLine("Dies ist keine gültige ganze Zahl!");
//}


//Übung 3: Zahlen hochzählen(while)
//Aufgabe
//Schreibe ein Programm, das:
//1.
//Den Benutzer nach einer Startzahl fragt
//2.
//Die Zahlen bis 10 hochzählt
//3.
//Jede Zahl in einer neuen Zeile ausgibt
//Hinweise
//•
//Verwende eine while-Schleife
//•
//Die Schleife soll so lange laufen, bis die Zahl 10 erreicht ist

//            Console.WriteLine("Bitte eine Startzahl eingeben und Enter drücken:");

//            string eingabe = Console.ReadLine();

//            if (int.TryParse(eingabe, out int zahl))
//            {
//                if (zahl > 10)
//                {
//                    Console.WriteLine("Die Startzahl darf nicht höher als 10 sein!");
//                }
//                else

//                    while (zahl <= 10)
//                {
//                    Console.WriteLine(zahl);
//                    zahl++;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Das ist keine gültige Zahl.");
//            }








//        }
//    }
//}
