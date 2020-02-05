using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_Review_und_Extras
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Verbatin String und Escape Zeichen in einem String
            //Escape Zeichen
            //https://docs.microsoft.com/de-de/dotnet/standard/base-types/character-escapes-in-regular-expressions
            Console.WriteLine("Tabelle: Personal");
            Console.WriteLine("Vorname \t Nachname \t\t Wohnort");
            Console.WriteLine("Silke\t\tMusterfrau\t\tMünchen");
            Console.WriteLine("Max\t\tMustermann\t\tAugsburg");

            string directoryPath = "C:\\GitHub_Projects\\runtime";


            //String-Formatierung mittels VerbaTim-String (Einleitung mittels @ / Escape-Sequenzen sind nicht möglich, 
            ///dynamische Inhalte mittels $ schon)

             //Bsp für Pfadausgabe in Verbatim-String
            Console.WriteLine(@"C:\Programme\Anwendung.exe");
            string directoryPathVariante2 = @"C:\GitHub_Projects\runtime";

            //C:\GitHub_Projects\runtime
            #endregion

            #region Richtig Parsen von String -> int / float / decimal / long / short /byte etc

            // Beim Casten einer Zahl, kann das Problem entstehen, dass z.b Buchstaben oder eine größere Zahl eingegeben wird. 
            Console.Write("Bitte geben Sie eine Zahl ein: ");
            int zahl = int.Parse(Console.ReadLine());



            Console.Write("Bitte geben Sie eine Zahl ein: ");
            string eingabe = Console.ReadLine();

            
            //Richtiges Parsen von String nach Integer/Double/Float/Long etc 
            //Variante 1 besagt im validen Fall beim Umwandeln kann man im If-Block sorgenlos weiterarbeiten
            int valideZahl; 
            if (int.TryParse(eingabe, out valideZahl))
            {
                // Variable valideZahl ist stimmig
                Console.WriteLine($"Eingegebene Zahl {valideZahl} ist valide");
            }

            
            if (!int.TryParse(eingabe, out valideZahl))
            {
                //Eskaliere ich hier -> es entsteht eine Fehlermeldung und der Vorgang wird abgeborchen
                throw new Exception("Zahleneingabe war falsch");
            }
            #endregion


            #region einfache String überürfung, ob der String leer ist oder nur Leerzeichen beinhaltet
            Console.Write("Gebe ein Dateipfad ein >");
            string dateiPfad = Console.ReadLine();

            // Allgemeine Überprüfung von Stringeinabgen: Ist der String überhaupt initialisiert worden.
            if (string.IsNullOrEmpty(dateiPfad) || string.IsNullOrWhiteSpace(dateiPfad))
            {
                throw new Exception("");
            }
            #endregion

            #region Nullable-Typen, die Datentypen die ein null=Zuweisung verwenden.
            //Nullable Typen
            int naiveZahl = 0;
            int? zahlOhneInitialisierung = null;

            if (zahlOhneInitialisierung.HasValue)
            {

            }

            // zahl wird initialisiert
            zahlOhneInitialisierung = 111;

            
            if (zahlOhneInitialisierung.HasValue)
            {
                Console.WriteLine($"Juhu ich habe einen Wert zugewiesen bekommen {zahlOhneInitialisierung}");
                Console.WriteLine($"Juhu ich habe einen Wert zugewiesen bekommen {zahlOhneInitialisierung.Value}");

                Console.WriteLine(Addieren(zahlOhneInitialisierung, naiveZahl));
            }
            #endregion

            //CamelCase
            string firstName = string.Empty;
            string secondFirstName = string.Empty;

            //ungarische Notation
            string strFirstName = string.Empty;

            Console.ReadKey();
        }

        public static int Addieren(int? a, int b)
        {
            // Addieren funktioniert allerdings über die Property Value.
            return a.Value + b;
        }
    }
}
