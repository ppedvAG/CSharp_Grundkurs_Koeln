using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_Library
{
    public class Garage
    {
        private List<Fahrzeug> fahrzeugliste;

        public Garage()
        {
            fahrzeugliste = new List<Fahrzeug>();
        }

        public void Einparken(Fahrzeug einzuparkendesFahrzeug)
        {
            fahrzeugliste.Add(einzuparkendesFahrzeug);
        }

        public void DisplayInventar()
        {
            int flugzeugAnzahl = 0;
            int pkwAnzahl = 0; ;
            int schiffAnzahl = 0;
            int yachtAnzahl = 0;

            foreach (Fahrzeug currentFahrzeug in fahrzeugliste)
            {

                #region variante 1
                if (currentFahrzeug is Flugzeug)
                    flugzeugAnzahl++;

                if (currentFahrzeug is PKW)
                    pkwAnzahl++;

                if (currentFahrzeug is Yacht)
                {
                    yachtAnzahl++;
                    continue;
                }


                if (currentFahrzeug is Schiff)
                    schiffAnzahl++;

                #endregion

                #region Variante 2
                //if (currentFahrzeug is Flugzeug)
                //{
                //    flugzeugAnzahl++;
                //}
                //else if (currentFahrzeug is PKW)
                //{
                //    pkwAnzahl++;
                //}
                //else if (currentFahrzeug is Yacht)
                //{
                //    yachtAnzahl++;
                //    // continue; -> Continue wäre eine alternative,  wenn nur mit if gearbeitet wird
                //}
                //else if (currentFahrzeug is Schiff)
                //{
                //    schiffAnzahl++;
                //}
                //else
                //{
                //    Console.WriteLine("Unbekanntes Objekt");
                //}
                #endregion


            }

            Console.WriteLine("Garageninventar: ");
            Console.WriteLine($"Flugzeuganzahl : \t {flugzeugAnzahl}");
            Console.WriteLine($"PKWanzahl: \t\t {pkwAnzahl}");
            Console.WriteLine($"Schiffanzahl: \t {schiffAnzahl}");
            Console.WriteLine($"Yachanzahl: \t {yachtAnzahl}");
        }

        public void VerdoppelAlleFahrzeugeDieEinCloneImplementiertHaben()
        {
            List<Fahrzeug> geklonteFahrzeuge = new List<Fahrzeug>();
            foreach (Fahrzeug currentFahrzeug in fahrzeugliste)
            {
                if (currentFahrzeug is ICloneable)
                {
                    ICloneable clonbareFahrzeug = (ICloneable)currentFahrzeug;
                    Fahrzeug clonedVehicle = (Fahrzeug)clonbareFahrzeug.Clone();
                    clonedVehicle.Farbe = "gelb";

                    geklonteFahrzeuge.Add(clonedVehicle);
                }
            }

            // Nachdem meine geklonte Fahrzeugliste erstellt wurde, werde ich diese auch in meine Garage einparken
            fahrzeugliste.AddRange(geklonteFahrzeuge);
        }

        public List<Fahrzeug> GebeMirAlleGelbenFahrzeugeZurueck()
        {
            return fahrzeugliste.Where(n => n.Farbe == "Gelb").OrderBy(n => n.Baujahr).ToList();
        }

        public List<Fahrzeug> GebeMirAlleFahrzeugeDieEineWasserlizenBenötigen()
        {
            List<Fahrzeug> fahrzeugeMitWasserFahrLizenz = new List<Fahrzeug>();

            foreach (Fahrzeug currentFahrzeug in fahrzeugliste)
            {
                if (currentFahrzeug is IWasserFahrLizenz)
                {
                    fahrzeugeMitWasserFahrLizenz.Add(currentFahrzeug);
                }
            }


            return fahrzeugeMitWasserFahrLizenz;
        }
    }
}
