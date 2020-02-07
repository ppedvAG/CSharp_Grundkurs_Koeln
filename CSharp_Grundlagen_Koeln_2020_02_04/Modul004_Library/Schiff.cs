using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_Library
{
    public class Schiff : Fahrzeug, IWasserFahrLizenz
    {
        //Nested Typ
        public enum Antriebskraft { Wind, Diesel, Muskelkraft }
        public double Tiefgang { get; set; }
        public Antriebskraft Antrieb { get; set; }
        public DateTime LizenzWurdeAusgestellt { get; set; }

        public Schiff(string marke, int baujahr, double maxGeschwinigkeit, string farbe, double tiefgang, Antriebskraft antriebskraft)
            : base(marke, baujahr, maxGeschwinigkeit, farbe)
        {
            this.Tiefgang = tiefgang;
            this.Antrieb = antriebskraft;
        }

        public void AnzeigeDerWasserLizent()
        {
            Console.WriteLine($"Wasserlizenz ist gültig seit {LizenzWurdeAusgestellt.ToShortDateString()}");
        }
    }
}
