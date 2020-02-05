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
        private  double maxGeschwindigkeit;
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
                return aktGeschwindigkeit;
            }

            set
            {
                if (value >= 0)
                    aktGeschwindigkeit = value;
                else
                    throw new Exception("Negative Zahlen werden nicht übernommen");
            }
        }


        //Read Property 
        public string Tacho
        {
            get
            {
                return AktGeschwindigkeit.ToString() + " | " + maxGeschwindigkeit.ToString();
            }
        }
        #endregion

        #region Methoden
        public void Methode()
        {

        }
        #endregion
    }

    public class Addition
    {
        private int? zahl1;
        private int? zahl2;

        public int? Zahl1
        {
            get
            {
                if (!zahl1.HasValue)
                    return 0;

                return zahl1;
            }

            set
            {
                zahl1 = value;
            }
        }

        public int? Zahl2
        {
            get
            {
                if (!zahl2.HasValue)
                    return 0;

                return zahl2;
            }

            set
            {
                zahl2 = value;
            }
        }

        
    }
}
