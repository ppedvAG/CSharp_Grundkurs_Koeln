using Modul004_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_2_Class_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration + Instanziierung
            Fahrzeug fahrzeug = new Fahrzeug();

            //Deklaration
            Fahrzeug fahrzeug1;
            //Instanziierung
            fahrzeug1 = new Fahrzeug();

            
            fahrzeug.Marke = "Lufthansa";
            fahrzeug.AktGeschwindigkeit = 100;
        }
    }
}
