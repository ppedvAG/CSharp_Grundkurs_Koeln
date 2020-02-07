using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul005_1_GenericListen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generische Liste 
            // List<T> 


            List<string> stringListe = new List<string>();

            Bearbeitung(stringListe);
            //Diese IListe hat nur eine Teilmenge an Methoden, die die List verwendet;
            //Depency Injection
            IList<string> list = new List<string>();
            
            stringListe.Add("Element1");
            stringListe.Add("Element2");
            stringListe.Add("Element3");

            foreach (string currentString in stringListe)
            {
                Console.WriteLine(currentString);
            }

            Console.WriteLine($"Element1 wird ausgegeben: {stringListe[0]}");

            List<string> weitereStringListe = new List<string>();
            weitereStringListe.Add("Hallo liebe Teilnehmer");
            weitereStringListe.Add("Hallo Köln");

            stringListe.AddRange(weitereStringListe);

            //stringListe.Clear(); Mit Clear kann man eine Liste auch löschen

            List<string> eingeschränkteListe = new List<string>(10); //List kann maximal 10 Elemente aufnehmen


            List<Person> personenListe = new List<Person>
            {
                new Person
                {
                    Vornamen = "Max",
                    Nachname = "Mustermann"
                },
                new Person
                {
                    Vornamen = "Steffi",
                    Nachname = "Musterfrau"
                }
            };

            //Mit Predicate kann man Teilmengen selektieren, verarbeiten oder auch löschen

            // Lösche alle Teilnehmer die den Buchstaben 'M' beinhalten
            personenListe.RemoveAll(n => n.Nachname.Contains("M")); 
            personenListe.RemoveAll(n => n.Vornamen == "Max");
            #endregion
            #region Stack
            Stack<string> stack = new Stack<string>();

            // Mit Push lege ich ein Element auf den Stabel 
            stack.Push("Element1");
            stack.Push("Element2");
            stack.Push("Element3");

            // Mit Peek lese ich den obersten Eintrag vom Stabel aus
            string ausgelesenesElement = stack.Peek();

            // Mit Pop lese ich den obersten Eintrag vom Stabel aus UND lösche diesen vom Stack
            string weggenommenesElement = stack.Pop();
            #endregion
            #region Queue
            Queue<string> warteschlange = new Queue<string>();

            warteschlange.Enqueue("Teilnehmer 1");
            warteschlange.Enqueue("Teilnehmer 2");
            warteschlange.Enqueue("Teilnehmer 3");

            //Peek lese den ältesten Eintrag aus
            string ausgelesenerTeilnehmer = warteschlange.Peek();

            //Dequeue wird der älteste Eintrag ausgelesen und in der Queue gelöscht
            string teilnehmer = warteschlange.Dequeue();
            #endregion

            #region Dictonary
            Dictionary<int, Person> buegerRegister = new Dictionary<int, Person>();
            buegerRegister.Add(0, new Person { Vornamen = "Max", Nachname = "Mustermann" });
            buegerRegister.Add(1, new Person { Vornamen = "Steffi", Nachname = "Musterfrau"});
            buegerRegister.Add(2, new Person { Vornamen = "Julia", Nachname = "Sonnenschein" });
            buegerRegister.Add(3, new Person { Vornamen = "Mirko", Nachname = "Knurrig" });
            buegerRegister.Add(4, new Person { Vornamen = "Vadzim", Nachname = "Müller" });
            buegerRegister.Add(5, new Person { Vornamen = "Boris", Nachname = "Becker" });
            buegerRegister.ContainsKey(5);
            //buegerRegister.ContainsValue(new Person { Vornamen = "Max", Nachname = "Mustermann" }); -> Wird seltener Verwendet, lieber den Algoritmus an ContainsKey anlehnen.

            foreach (KeyValuePair<int, Person> item in buegerRegister)
            {
                Console.WriteLine(item.Key); // auslesen der linken Spalte
                Console.WriteLine(item.Value); //auslesen der rechten Spalte 
            }
            #endregion

            //using System.Collections;
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Halli Hallo", new Person { Vornamen = "Max", Nachname = "Mustermann" });
            hashtable.Add(5, 55);
        }

        public static void Bearbeitung (IList<string> list)
        {
            
        }
    }

    public class Person
    {
        public string Vornamen { get; set; }
        public string Nachname { get; set; }
    }
}
