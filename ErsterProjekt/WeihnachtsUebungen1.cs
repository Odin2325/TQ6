//using System.Collections.Generic;
//using System.Globalization;
//using System.Reflection.Metadata;
//using System.Runtime.ConstrainedExecution;
//using System.Xml.Linq;

//namespace ErsterProjekt
//{
//    internal class WeihnachtsUebungen1
//    {
//        static void Main()
//        {

//            //1.
//            //Wir bekommen einen Namen von der Konsole.
//            //Und es wird auf die Konsole ausgegeben in der form:
//            //Eins für NameVariable, und eins für mich.
//            //Wenn kein name eingegeben wird, dann soll die ausgabe so aussehen:
//            //Eins für dich, und eins für mich.


//            //Console.WriteLine("Bitte deinen Namen eingeben und Enter drücken:");
//            //string name = Console.ReadLine();

//            //if (name.Trim() == "")//mit Trim entferne ich die Leerzeichen und überprüfe mit == "" ob die Variable leer ist!
//            //{
//            //    Console.WriteLine("Eins für dich und eins für mich.");
//            //}
//            //else
//            //{
//            //    Console.WriteLine($"Eins für {name} und eins für mich.");
//            //}


//            //2.
//            //Ihre Aufgabe ist es, eine Zahl in eine Zeichenkette umzuwandeln, die
//            //Regentropfen Geräusche enthält, die bestimmten möglichen Faktoren entsprechen.
//            //Ein Faktor ist eine Zahl, die eine andere Zahl gleichmäßig teilt und keinen Rest
//            //übrig lässt.Die einfachste Art zu prüfen, ob eine Zahl ein Faktor einer anderen ist,
//            //ist die Modulo-Operation.Zum Beispiel, um zu sehen, ob eine Zahl durch 8 teilbar
//            //ist, würden wir x% 8 schreiben.
//            //Die Regeln für Regentropfen lauten: Wenn eine gegebene Zahl:
//            //3 als Faktor hat, addiere 'Pling' zu dem Ergebnis.
//            //5 als Faktor hat, füge 'Plang' zum Ergebnis hinzu.
//            //7 als Faktor hat, füge 'Plong' zum Ergebnis hinzu.
//            //keine der Zahlen 3, 5 oder 7 als Faktor hat, sollte das Ergebnis die Ziffern
//            //der Zahl sein.
//            //Beispiele
//            //28 hat 7 als Faktor, aber nicht 3 oder 5, also wäre das Ergebnis "Plong".
//            //30 hat sowohl 3 als auch 5 als Faktoren, aber nicht 7, also wäre das Ergebnis
//            //"PlingPlang".
//            //34 wird nicht durch 3, 5 oder 7 faktorisiert, das Ergebnis wäre also "34".

//            //Console.WriteLine("Bitte eine Zahl eingeben und Enter drücken:");

//            //string eingabe = Console.ReadLine();

//            //if (int.TryParse(eingabe, out int zahl))
//            //{
//            //    string ausgabetext = "";

//            //    if (zahl % 3 == 0)
//            //        ausgabetext += "Pling ";

//            //    if (zahl % 5 == 0)
//            //        ausgabetext += "Plang ";

//            //    if (zahl % 7 == 0)
//            //        ausgabetext += "Plong ";

//            //    if (ausgabetext == "")
//            //        ausgabetext = zahl.ToString();

//            //    Console.WriteLine(ausgabetext);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Das ist keine gültige Zahl!");
//            //}



//            //4.
//            //Geben Sie eine Jahreszahl an, um festzustellen, ob es sich um ein Schaltjahr
//            //handelt.
//            //Das Schwierige dabei ist, dass ein Schaltjahr im Gregorianischen Kalender
//            //in jedem Jahr, das gleichmäßig durch 4 teilbar ist
//            //außer in jedem Jahr, das gleichmäßig durch 100 teilbar ist
//            //es sei denn, das Jahr ist auch durch 400 teilbar.
//            //Zum Beispiel ist 1997 kein Schaltjahr, aber 1996 schon. 1900 ist kein Schaltjahr,
//            //aber 2000 ist ein Schaltjahr.

//            //Console.WriteLine("Bitte eine Jahreszahl eingeben und Enter drücken:");

//            //string eingabe = Console.ReadLine();

//            //if (int.TryParse(eingabe, out int jahr))
//            //{
//            //    if ((jahr % 4 == 0 && jahr % 100 != 0) || jahr % 400 == 0)
//            //    {
//            //        Console.WriteLine($"{jahr} ist ein Schaltjahr!");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine($"{jahr} ist kein Schaltjahr!");
//            //    }
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Das ist keine gültige Jahreszahl!");
//            //}



//            //3.
//            //Berechnen Sie anhand eines Alters in Sekunden, wie alt jemand auf:
//            //Merkur: Umlaufzeit 0,2408467 Erdjahre
//            //Venus: Umlaufzeit 0,61519726 Erdjahre
//            //Erde: Umlaufzeit 1,0 Erdjahre, 365,25 Erdtage oder 31557600 Sekunden
//            //Mars: Umlaufzeit 1,8808158 Erdjahre
//            //Jupiter: Umlaufzeit 11,862615 Erdjahre
//            //Saturn: Umlaufzeit 29,447498 Erdjahre
//            //Uranus: Umlaufzeit 84,016846 Erdjahre
//            //Neptun: Umlaufzeit 164,79132 Erdjahre
//            //Wenn man Ihnen also sagt, dass jemand 1.000.000.000 Sekunden alt ist, sollten Sie
//            //in der Lage sein zu sagen, dass er 31,69 Erdjahre alt ist.

//            //Console.WriteLine("Bitte Alter in Sekunden eingeben und Enter drücken:");

//            //string eingabe = Console.ReadLine();

//            //if (double.TryParse(eingabe, out double sekunden))
//            //{
//            //    double erdjahre = sekunden / 31557600;

//            //    Console.WriteLine($"Erde: {erdjahre:F2} Jahre!");
//            //    Console.WriteLine($"Merkur: {erdjahre / 0.2408467:F2} Jahre!");
//            //    Console.WriteLine($"Venus: {erdjahre / 0.61519726:F2} Jahre!");
//            //    Console.WriteLine($"Mars: {erdjahre / 1.8808158:F2} Jahre!");
//            //    Console.WriteLine($"Jupiter: {erdjahre / 11.862615:F2} Jahre!");
//            //    Console.WriteLine($"Saturn: {erdjahre / 29.447498:F2} Jahre!");
//            //    Console.WriteLine($"Uranus: {erdjahre / 84.016846:F2} Jahre!");
//            //    Console.WriteLine($"Neptun: {erdjahre / 164.79132:F2} Jahre!");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Ungültige Eingabe!");
//            //}



//            //RNA: "AUGUUUUCUUAAAUG" =>
//            //Codons: "AUG", "UUU", "UCU", "UAA", "AUG" =>
//            //Protein: "Methionin", "Phenylalanin", "Serin"
//            //Beachten Sie, dass das Stoppcodon "UAA" die Übersetzung beendet und das letzte
//            //Methionin nicht in die Proteinsequenz übersetzt wird.
//            //Nachstehend sind die Codons und die daraus resultierenden Aminosäuren
//            //aufgeführt, die für die Übung benötigt werden:

//            //Codon Protein
//            //AUG Methionin
//            //UUU, UUC Phenylalanin
//            //UUA, UUG Leucin
//            //UCU, UCC, UCA, UCG Serin
//            //UAU, UAC Tyrosin
//            //UGU, UGC Cystein
//            //UGG Tryptophan
//            //UAA, UAG, UGA STOP

//            //Programmstart Unterricht:
//            Console.WriteLine("RNA - Proteinen Konvertierer\n===============================================");
//            Console.WriteLine("Geben Sie bitte eine RNA sequenz ein: ");
//            string? rnaSequenz = Console.ReadLine(); //Fuer Testing. Dannach mit Console.ReadLine() ersetzen.
//                                                     //Index               0123456789 10 11 12 13 14 15

//            //Hallo => hat 5 zeichen
//            //string proteine = "";

//            //bool stopGefunden = false;

//            //int zaehler = 0;

//            //while (!stopGefunden)
//            //{
//            //    string codon = rnaSequenz.Substring(zaehler, 3);
//            //Console.WriteLine("Codon: " + codon);
//            //Spaeter schleife mit zaehler erstellen. Jeweils um 3 erhoehen.

//            //Alternative - Patternmatching switch
//            //Kurzform von normalen switch.
//            //proteine += codon switch
//            //{
//            //    "AUG" => "Methionin ",
//            //    "UUU" or "UUC" => "Phenylalanin ",
//            //    "UUA" or "UUG" => "Leucin"
//            //};

//            //    switch (codon)
//            //    {
//            //        case "AUG":
//            //            proteine += "Methionin ";
//            //            break;
//            //        case "UUU" or "UUC":
//            //            proteine += "Phenylalanin ";
//            //            break;
//            //        case "UUA" or "UUG":
//            //            proteine += "Leucin ";
//            //            break;
//            //        case "UCU" or "UCC" or "UCA" or "UCG":
//            //            proteine += "Serin ";
//            //            break;
//            //        case "UAU" or "UAC":
//            //            proteine += "Tyrosin ";
//            //            break;
//            //        case "UGU" or "UGC":
//            //            proteine += "Cystein ";
//            //            break;
//            //        case "UGG":
//            //            proteine += "Tryptophan ";
//            //            break;
//            //        case "UAA" or "UAG" or "UGA":
//            //            Console.WriteLine("Stop Sequenz gefunden!");
//            //            stopGefunden = true;
//            //            break;
//            //        default:
//            //            Console.WriteLine("Keine RNA Sequenz eingegeben. Achten Sie auf Ihre Eingabe bitte!");
//            //            return;
//            //    }
//            //    zaehler += 3;
//            //    if (zaehler + 3 > rnaSequenz.Length)
//            //    {
//            //        Console.WriteLine("Keine Stop Sequenz gefunden.");
//            //        Console.WriteLine("RNA Sequenz vorbei. Programm wird terminiert.");
//            //        break;
//            //    }
//            //}

//            //Console.WriteLine("Gefundene Proteinen: " + proteine);
//            //Programmende




//            ////Aufgabe:Schreibe eine for-Schleife die alle Zahlen von 0 bis 10 aufsummiert und nach der Schleife die Summe ausgibt:

//            //int summe = 0;

//            //for (int i = 0; i < 11; i++)
//            //{
//            //    summe += i;
//            //}

//            //Console.WriteLine($"Die Summe von 0 bis 10 ist: {summe}");
//            //Programmende


//            //Programmstart Finale Version:
//            Console.WriteLine("RNA - Proteinen Konvertierer\n===============================================");
//            Console.WriteLine("Geben Sie bitte eine RNA sequenz ein: ");
//            string? rnaSequenz = Console.ReadLine();

//            if (rnaSequenz == null || rnaSequenz == "")
//            {
//                Console.WriteLine("Leere RNA Sequenz.");
//                return;
//            }

//            string proteine = "";

//            bool stopGefunden = false;

//            int zaehler = 0;

//            while (!stopGefunden)
//            {
//                string codon = rnaSequenz.Substring(zaehler, 3);

//                switch (codon)
//                {
//                    case "AUG":
//                        proteine += "Methionin ";
//                        break;
//                    case "UUU" or "UUC":
//                        proteine += "Phenylalanin ";
//                        break;
//                    case "UUA" or "UUG":
//                        proteine += "Leucin ";
//                        break;
//                    case "UCU" or "UCC" or "UCA" or "UCG":
//                        proteine += "Serin ";
//                        break;
//                    case "UAU" or "UAC":
//                        proteine += "Tyrosin ";
//                        break;
//                    case "UGU" or "UGC":
//                        proteine += "Cystein ";
//                        break;
//                    case "UGG":
//                        proteine += "Tryptophan ";
//                        break;
//                    case "UAA" or "UAG" or "UGA":
//                        Console.WriteLine("Stop Sequenz gefunden!");
//                        stopGefunden = true;
//                        break;
//                    default:
//                        Console.WriteLine("Keine RNA Sequenz eingegeben. Achten Sie auf Ihre Eingabe bitte!");
//                        return;
//                }
//                zaehler += 3;
//                if (zaehler + 3 > rnaSequenz.Length)
//                {
//                    Console.WriteLine("Keine Stop Sequenz gefunden.");
//                    Console.WriteLine("RNA Sequenz vorbei. Programm wird terminiert.");
//                    break;
//                }
//            }

//            Console.WriteLine("Gefundene Proteinen: " + proteine);
//            //Programmende



//        }
//    }
//}

