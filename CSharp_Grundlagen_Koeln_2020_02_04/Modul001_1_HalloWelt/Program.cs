using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul001_1_HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            //sdfasdfasdfasdf
            Console.OutputEncoding = Encoding.UTF8;

            #region Beispiel1: Hallo Welt
            // Ausgabe des Textes Hallo Welt
            Console.WriteLine("Hallo Welt");

            // Programm wartet auf einen Tastendruck
            Console.ReadKey();
            #endregion

            #region Beispiel2 Ausgabe einer Variable
            Console.WriteLine("----- Hallo Variablen ------");
            //Deklaration einer Integer-Variable
            int alter;
            
            
            
            //Initialisierung einer Variable;
            alter = 36;

            //Deklaratrion und Initialisierung 
            string stadt = "Berlin";

            Console.WriteLine(alter);
            Console.WriteLine(stadt);

            //Kleines Extra
            alter = 36;
            Console.ReadKey();
            #endregion

            //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            Console.WriteLine("----- Gleitkomma Datentypen ------");
            // decimal Datentyp wird für Geldbeträge verwendet. Microsoft hat diesen Datentyp als juristisch valide ausgesprochen.
            decimal geldbetrag = 1000.567m;
            Console.WriteLine(geldbetrag);

            double d = 3D;
            d = 4D;
            Console.WriteLine(d);

            float f = 3_000.5F;
            f = 5.4f;
            Console.WriteLine(f);

            Console.WriteLine("€");
            Console.ReadKey();



            Console.WriteLine("----- Ausgaben von String ------");
            string vorname = "Max";
            Console.WriteLine("{0} ist {1} und kommt aus {2}", vorname, alter, stadt);
            Console.WriteLine($"{vorname} ist {alter} und kommt aus {stadt}");
            Console.ReadKey();

            Console.WriteLine("----- Einlesen von Konsoleneingaben ------");

            Console.Write("Bitte geben Sie eine Zahl ein");
            string leseZeile = Console.ReadLine();

            //Konventiere mit int.Parse
            Console.Write("Bitte geben Sie eine Zahl ein");
            int zahlDesTages = int.Parse(Console.ReadLine());

            //Konventiere mit Convert.ToInt32 
            Console.Write("Bitte geben Sie eine Zahl ein");
            zahlDesTages = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("---- Kommazahl wird in eine Ganzzahl gecastet. Was passiert bei den unterschiedlichen Möglichkeiten:");

            double doubleValue = 3.5;
            Console.WriteLine($"Der Wert 3.5 wird unterschiedlich gecastet");

            // Convert.To rundet 
            int result1 = Convert.ToInt32(doubleValue);
            float result2 = float.Parse("3.5");
            int result3 = (int)doubleValue; 

            Console.WriteLine($"Ausgabe1 mit Convert.ToInt32 = {result1}");
            Console.WriteLine($"Ausgabe3 mit direkter Konventierung = {result3}");


            

            Console.ReadKey();



        }
    }
}
