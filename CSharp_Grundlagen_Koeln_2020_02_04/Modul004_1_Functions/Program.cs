using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_1_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            Addiere(a, b);
            Addiere(a, b, 11, 22);
        }

        #region  Functionen und Überlagerungen
        /// <summary>
        /// Beschreibung der Methode
        /// </summary>
        /// <param name="a">Erste Zahl der Addition</param>
        /// <param name="b">Zweite Zahl der Addition</param>
        /// <returns>Das ERgebnis der Addition</returns>
        //public static int Addiere(int a, int b)
        //{
        //    return a + b;
        //}


        //public static float Addiere(float a, float b)
        //{
        //    return a + b;
        //}

        //int Addiere(int a, int b)
        //int Addiere(int a, int b, int c)

        /// <summary>
        /// Überlagerung einer Methoide int Addiere(int a, int b)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int Addiere(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Überlagerung einer Methoide int Addiere(int a, int b)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float Addiere(float a, int b, int c)
        {
            return a + b + c;
        }


        /// <summary>
        /// Beispiel für Optionale Parameter
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Addiere (int a, int b, int c=0, int d=5)
        {
            return a + b + c + d;
        }


        //Das PARAMS-Stichwort erlaubt die Übergabe einer beliebige Anzahl von gleichartigen Daten, welche innerhalb
        //der Methode als Array interpretiert werden
        public static int BildeSumme(params int[] summanden)
        {
            //Deklaration einer Integer-Hilfsvariablen und initialisierung auf 0
            int summe = 0;
            //Schleife über das übergebene Array
            foreach (var item in summanden)
            {
                //Hinzufügen der im Array betrachteten Zahl zur Variable
                summe += item;
            }
            //Rückgabe der Variablen
            return summe;
        }

        #endregion
    }
}
