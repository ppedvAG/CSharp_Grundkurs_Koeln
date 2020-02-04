using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul002_3_HalloSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("zahlen.txt");
           
            //for + tab + tab -> shortcut
            for (int i = 0; i < 100; i++)
            {
                sw.WriteLine(i);
            }
            sw.Close();

            StreamReader sr = new StreamReader("zahlen.txt");
            int summe = 0;

            //while + tab + tab ->shortcut

            //sr.EndOfStream -> lese ein, bis das Ende erreicht ist.
            // In unserem Fall. Das Dateiende
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);

                summe += int.Parse(line);
            }

            Console.WriteLine(summe);
            sr.Close();

            //do
            //{
            //    Console.WriteLine(DateTime.Now);
            //} while (DateTime.Now.Second < 30);

            int[] intArray = new int[] { 5, 10, 15, 20, 25, 30, 33, 44, 55, 66, 77, 88, 99 };
            
            List<int> integerListe = new List<int>();
            integerListe.Add(5);
            integerListe.Add(10);
            integerListe.Add(15);
            integerListe.Add(20);

            foreach (int currentIntegerValue in intArray)
            {
                Console.WriteLine(currentIntegerValue);
            }

            foreach (int aktuellerIntegerWert in integerListe)
            {
                Console.WriteLine(aktuellerIntegerWert);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }


            Console.ReadKey();
        }
    }
}
