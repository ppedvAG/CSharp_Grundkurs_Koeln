using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_Library
{
    public class Fahrzeug
    {
        #region Variablen
        private string marke;
        private int baujahr;
        private double aktGeschwindigkeit;
        private double maxGeschwindigkeit;

        #endregion

        #region Konstruktoren
        public Fahrzeug()
        {

            MotorLäuft = false;
            AktGeschwindigkeit = 0;

            AnzahlErstellterFahrzeuge++;
        }

        public Fahrzeug(string marke, int baujahr, double maxGeschwindigkeit)
            : this()
        {
            Marke = marke;
            Baujahr = baujahr;
            MaxGeschwindigkeit = maxGeschwindigkeit;
        }

        public Fahrzeug(string marke, int baujahr, double maxGeschwindigkeit, string farbe)
            : this(marke, baujahr, maxGeschwindigkeit)
        {
            Farbe = farbe;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Fahrzeug"/> class.
        /// </summary>
        /// <param name="fahrzeug">The fahrzeug.</param>
        public Fahrzeug(Fahrzeug fahrzeug)
        {
            this.Marke = fahrzeug.Marke;
            this.Baujahr = fahrzeug.Baujahr;
            this.MaxGeschwindigkeit = fahrzeug.MaxGeschwindigkeit;
            this.MotorLäuft = fahrzeug.MotorLäuft;
            this.AktGeschwindigkeit = fahrzeug.AktGeschwindigkeit;
            this.Farbe = fahrzeug.Farbe;
        }

        // Variante 2 eines Kopierkonstruktors
        //public Fahrzeug(Fahrzeug fahrzeug)
        //    : this(fahrzeug.Marke, fahrzeug.Baujahr, fahrzeug.MaxGeschwindigkeit)
        //{
        //    this.Farbe = fahrzeug.Farbe;
        //}
        #endregion

        #region Properties
        // Properties greifen auf Variablen zu, liest diese aus oder setzt Werte auf die Variablen
        public string Marke
        {
            // Lesemodus für eine Variable 
            get
            {
                if (this.marke == string.Empty)
                    return "Kein Hersteller";

                return this.marke;
            }

            // Set ist der Schreibmodus einer Variable
            set
            {

                // Valierdung und Zuweisen
                if (value != string.Empty)
                    this.marke = value;
            }
        }
        public double AktGeschwindigkeit
        {
            get
            {
                // Auch hier kann ich mit Code den Lesefluss beeinflussen, bzw Default Werte zurück, wenn eine gewissen kommt. 
                return this.aktGeschwindigkeit;
            }

            set
            {
                //weitere Logik....
                aktGeschwindigkeit = value;
            }
        }
        public int Baujahr
        {
            get => baujahr;
            set => baujahr = value;
        }
        public double MaxGeschwindigkeit
        {
            get => maxGeschwindigkeit;
            set => maxGeschwindigkeit = value;
        }

        //Read Property 
        public string Tacho
        {
            get
            {
                return AktGeschwindigkeit.ToString() + " | " + MaxGeschwindigkeit.ToString();
            }
        }

        //Auto Property
        public bool MotorLäuft { get; set; }
        public string Farbe { get; set; }
        #endregion

        #region Methoden
        public void StartMotor()
        {
            this.MotorLäuft = true;
        }

        public void StoppeMotor()
        {
            this.MotorLäuft = false;
            this.AktGeschwindigkeit = 0;
        }

        public void Beschleunige(double a)
        {
            // Läuft der Motor
            if (MotorLäuft)
            {
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                else if (this.AktGeschwindigkeit + a < 0)
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += a;
            }
        }


        public override string ToString()
        {
            string ausgabeString = $"Fahrzeugmarke: {Marke} Baujahr: {Baujahr} Farbe: {Farbe} MaximaleGeschwindigkeit: {MaxGeschwindigkeit}";
            return ausgabeString;
        }
        #endregion

        #region static methoden
        public static double KmhToMph(double kmh)
        {
            return 0.6214 * kmh;
        }

        public static double MphToKmH(double mph)
        {
            return mph * 1.60934;
        }

        public static int AnzahlErstellterFahrzeuge { get; private set; } = 0;
        #endregion
    }
}
