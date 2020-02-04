using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul002_1_Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung von Beispiel-Variablen
            int a = 25;
            int b = 30;

            #region if - statement
            //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/if-else

            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen

            if (a < b)
                Console.WriteLine("A ist kleiner als B");
            else if (a > b)
            {
                //Es kann beliebig viele ELSE-IF-Blöcke geben
                Console.WriteLine("A ist größer als B");
            }
            else
            {
                //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
                Console.WriteLine("A und B sind gleich");
            }
            Console.ReadKey();

            //Kurznotation:
            //(Bedingung) ? TrueAusgabe : FalseAusgabe
            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            #endregion



            
        }
    }
}
