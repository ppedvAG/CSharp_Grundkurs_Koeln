using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_Library
{
    public class PKW : Fahrzeug, ICloneable
    {
        private int anzahlTueren;
        private int anzahlRaeder;

        public PKW(string marke, int baujahr, double maxGeschwindigkeit, string farbe, int anzahlTueren, int anzahlRaeder)
            : base(marke, baujahr, maxGeschwindigkeit, farbe)
        {
            this.AnzahlTueren = anzahlTueren;
            this.AnzahlRaeder = anzahlRaeder;
        }

        public int AnzahlTueren
        {
            get => anzahlTueren;
            set => anzahlTueren = value;
        }
        public int AnzahlRaeder
        {
            get => anzahlRaeder;
            set => anzahlRaeder = value;
        }

        public object Clone()
        {
            return new PKW(this.Marke, this.Baujahr, this.MaxGeschwindigkeit, this.Farbe, this.AnzahlTueren, this.AnzahlRaeder);
        }
    }
}
