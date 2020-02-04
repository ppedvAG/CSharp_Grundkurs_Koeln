using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul003_Enums_Switch
{

    //Index startet hier expliziet beim Wert 1. Sonst würde der Index bei 0 starten. 
    enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag }

    class Program
    {
        static void Main(string[] args)
        {


            //Vor der Zeit des Enum, wurden Wochentage so dargstellt
            //Mit dem Nachteil, dass die Übersicht verloren geht, an welchen Index, welcher Wert steht
            string[] Wochentage = new string[7];
            Wochentage[0] = "Montag";
            Wochentage[1] = "Dienstag";
            Wochentage[2] = "Mittwoch";
            Wochentage[3] = "Donnerstag";
            Wochentage[4] = "Freitag";
            Wochentage[5] = "Samstag";
            Wochentage[6] = "Sonntag";

            
            //Deklaration und Initialisierung einer Variablen vom Enumerator-Typ
            Wochentag heute = Wochentag.Dienstag;
            Console.WriteLine($"Heute ist {heute}");

            //Casten von Integer Werten auf Enums, mithilfe einer Zählschleife
            for (int i = 1; i < 8; i++ )
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }

            // Casten von Integer Werten auf Enums, mithilfe einer Benutzereingabe
            heute = (Wochentag)int.Parse(Console.ReadLine());

            // Enum & BitMask -> https://docs.microsoft.com/de-de/dotnet/api/system.enum.hasflag?view=netframework-4.8
            
            
            if (heute == Wochentag.Montag)
            {

            }
            else if (heute == Wochentag.Dienstag)
            {

            }
            else if (heute == Wochentag.Mittwoch)
            {

            }
            else if (heute == Wochentag.Donnerstag)
            {

            }
            else if (heute == Wochentag.Freitag)
            {
                //
            }
            else if (heute == Wochentag.Samstag)
            {
                MacheWasDirAmSamstagGefaellt();
            }
            else
            {
            }




            //1) switch + tab + tab
            //2) eingabe der enum variable heute
            //3) [Enter] [Enter]
            switch (heute)
            {
                case Wochentag.Montag:
                    break;
                case Wochentag.Dienstag:
                    break;
                case Wochentag.Mittwoch:
                    break;
                case Wochentag.Donnerstag:
                    break;
                case Wochentag.Freitag:
                    break;
                case Wochentag.Samstag:
                    MacheWasDirAmSamstagGefaellt();

                    break;
                case Wochentag.Sonntag:
                    break;
                default:
                    break;
            }

            string englischeBeschreibung = GebeMirWochentagInEnglisch(heute);
            Console.WriteLine(englischeBeschreibung);


            string eingabe = string.Empty;
            eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "Optionen":
                    //Gehe ins Menü Optionen
                    break;
                case "Info":
                    //Gehe in das Infofesten
                    break;
                default:
                    //Gehe nochmals in Menü und frage nochmal nach der Eingabe
                    break;
            }


            int a = 11;
            
            switch(a)
            {
                case 5:
                    Console.WriteLine("Irgendwas");
                    break;
                //a wird in b eingelegt (zu überprüfende Variable wir für Bedingungsprüfung vorbereitet)
                //und mittels when auf eine Eigenschaft geprüft
                case int b when b > 10 || b < 3:
                    Console.WriteLine("a ist größer als 10");
                    break;
                case int b when b > 10 && b < 3:
                    Console.WriteLine("a ist größer als 10");
                    break;
                case int b when b > 10:
                    Console.WriteLine("a ist größer als 10");
                    break;
            }

            Console.ReadKey();
        }

        static void MacheWasDirAmSamstagGefaellt()
        {

        }

        static string GebeMirWochentagInEnglisch(Wochentag wochentag)
        {
            switch (wochentag)
            {
                case Wochentag.Montag:
                    return "Monday";
                case Wochentag.Dienstag:
                    return "Tuesday";
                case Wochentag.Mittwoch:
                    return "Wendesday";
                case Wochentag.Donnerstag:
                    return "Thursday";
                case Wochentag.Freitag:
                    return "Friday";
                case Wochentag.Samstag:
                    return "Saturday";
                case Wochentag.Sonntag:
                    return "Sunday";
                default:
                    return "Error";
            }
        }

        static int Addieren(int a, int b)
        {
            return a + b;
        }

        
    }

    
}
