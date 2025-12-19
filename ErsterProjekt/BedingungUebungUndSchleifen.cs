//namespace ErsterProjekt
//{
//    internal class BedingungUebungUndSchleifen
//    {
//        static void Main() 
//        {

            //Random zufallszahlGenerator = new Random();

            //int zufallsZahl = zufallszahlGenerator.Next();

            //Console.WriteLine(zufallsZahl);



            ////Übung von microsoft.learn

            //string permission = "Admin|Manager";
            //int level = 55;

            //string nachricht = "";

            //if (permission.Contains("Admin") && level > 55)
            //    nachricht = "Welcome, Super Admin user.";
            //else if (permission.Contains("Admin"))
            //    nachricht = "Welcome, Admin user.";
            //else if (permission.Contains("Manager") && level >= 20)
            //    nachricht = "Contact an Admin for access.";
            //else
            //    nachricht = "You do not have sufficient privileges";

            //Console.WriteLine(nachricht);



            //Schleifen:

            //int zahl = 1;

            //while (zahl < 100)
            //{
            //    zahl += 10;

            //    if (zahl > 30 && zahl < 50)
            //    {
            //        Console.WriteLine("Diese Zahlen moegen wir nicht!");
            //        continue;
            //    }

            //    Console.WriteLine("Die Aktuelle Zahl ist: " + zahl);
            //}
            //Console.WriteLine("Schleife Vorbei!");






            //Von Nico gepullt:

            //string benutzername = "Bob123";

            //Console.WriteLine("Geben Sie bitte Ihr neues Passwort ein:");
            //string? passwort = Console.ReadLine();

            //while (passwort.Length < 10)
            //{
            //    Console.WriteLine("Versuchen Sie es bitte nochmals. Das Passwort muss mind. 10 Zeichen enthalten.");
            //    passwort = Console.ReadLine();
            //}

            //Console.WriteLine($"Dein Konto wurde erstellt. " +
            //    $"Sie haben folgende Zugangsdaten definiert:" +
            //    $"\nBenutzername: {benutzername}\n" +
            //    $"Passwort: {passwort}");


            //int zahl = 1;

            //while (zahl < 100)
            //{
            //    Console.WriteLine("Die Aktuelle Zahl ist: " + zahl);

            //    if (Console.ReadLine() == "quit")
            //    {
            //        Console.WriteLine("Die Schleife wird terminiert!");
            //        break;
            //    }
            //}

            //int zahl = 1;

            //while (zahl < 100)
            //{
            //    zahl += 10;

            //    if (zahl > 30 && zahl < 50)
            //    {
            //        Console.WriteLine("Diese Zahlen moegen wir nicht!");
            //        continue;
            //    }

            //    Console.WriteLine("Die Aktuelle Zahl ist: " + zahl);
            //}
            //Console.WriteLine("Schleife Vorbei!");

            //HA:
            //Es soll einen PAP erstellt werden und dannach ein programm geschrieben.
            //Ein Benutzer soll einen Konto erstellen.
            //Es gelten folgende regeln:
            //1.Das Benutzername muss mind. 5 Zeichen lang sein.
            //2.Das Passwort muss mind. 10 Zeichen lang sein und mit das buchstabe 'A' beginnen.
            //Sobald eine von diese Faelle nicht stimment, dann soll der Benutzer erneut die Daten eingeben.
            //Hinweis 1 schleife fuer Benutzername 1 schleife fuer passwort


            //string username;
            //string password;


            //Console.WriteLine("Bitte Benutzername mit mindestens 5 Zeichen erstellen:");
            //username = Console.ReadLine();

            //while (username.Length < 5)
            //{
            //    Console.WriteLine("Name zu kurz, bitte mindestens 5 Zeichen eingeben.");

            //    username = Console.ReadLine();
            //}


            //Console.WriteLine("Bitte Passwort mit mindestens 10 Zeichen erstellen und das erste Zeichen muss ein'A' sein:");

            //password = Console.ReadLine();

            //while (password.Length < 10 || !password.StartsWith("A"))
            //{
            //    Console.WriteLine("Passwort ungültig, bitte mindestens 10 Zeichen eingeben und das erste Zeichen muss ein 'A' sein.");

            //    password = Console.ReadLine();
            //}

            //Console.WriteLine("\nKonto erfolgreich erstellt!");



            //Aufgabe die summe aller werte von 1 bis <= 50 brechnen.
            //Dannach soll die gesamtsumme * 2 multipliziert werden
            //Und auf die Konsole ausgegeben werden.
            //Bitte einmal mit while und einmal mit do-while loesen.
            //Super Herausforderung. Die Ausgabe soll wie folgt aussehen:
            //0 + 1 + 2 + 3 = 6 Hinweis: resultat string verwenden!

            //int summe = 0;

            //int zaehler = 1;

            //while (zaehler <= 30)
            //{
            //    //0 + 1 + 2 + 3 + 4
            //}

            //While-Schleife
            //int summe = 0;

            //int zaehler = 1;

            //string resultat = "0";

            //while (zaehler <= 50)
            //{
            //    summe += zaehler;
            //    resultat += " + " + zaehler;
            //    zaehler++;
            //}

            //Console.WriteLine($"{resultat} und das Ganze dann multipliziert mit 2 ergibt = {summe * 2}");

            //Do-While-Schleife
            //int summe = 0;

            //int zaehler = 1;

            //string resultat = "0";

            //do
            //{
            //    summe += zaehler;




            //von Hamnnes
            //int summe = 0;
            //int zaehler = 1;
            //string resultat = "0";

            //do
            //{
            //    summe += zaehler;
            //    resultat += " + " + zaehler;
            //    zaehler++;
            //}
            //while (zaehler <= 50);

            //int ergebnis = summe * 2;

            //Console.WriteLine(resultat + " = " + ergebnis);






        }
    }
}
