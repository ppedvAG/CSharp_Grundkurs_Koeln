using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_Library
{
    // Fahrzeug ist die Basisklasse
    // Flugzeug ist die abgeleitete Klasse 
    public class Flugzeug : Fahrzeug
    {
        private double Spannweite { get; set; }

        private int MaxFlughoehe { get; set; }

        public Flugzeug(string marke, int baujahr, int maxGeschwindigkeit, string farbe, int spannweite, int maxFlughoehe)
            : base(marke, baujahr, maxGeschwindigkeit, farbe)
        {
            this.Spannweite = spannweite;
            this.MaxFlughoehe = maxFlughoehe;
        }
    }
}
