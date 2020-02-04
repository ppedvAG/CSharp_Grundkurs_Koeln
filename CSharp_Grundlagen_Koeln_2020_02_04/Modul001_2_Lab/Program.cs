using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul001_2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration der Variablen
            double zahl1;
            double zahl2;

            //Initialisierung der Variablen durch Benutzereingabe
            Console.Write("Bitte gib eine ganze Zahl ein: ");
            zahl1 = double.Parse(Console.ReadLine());
            Console.Write("Bitte gib eine Kommazahl ein: ");
            zahl2 = double.Parse(Console.ReadLine());

            //Berechnung und Ausgabe der Division:
            double max = Math.Max(zahl1, zahl2);
            double min = Math.Min(zahl1, zahl2);
            double erg = max / min;
            Console.WriteLine($"{max} / {min} = {erg}");

            //Programmpause
            Console.ReadKey();

        }
    }
}
