using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_Exception
{
    public class MeineException : Exception
    {
        public MeineException()
            : base("Das ist mein Fehler")
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string eingabe = Console.ReadLine();

                
                if (string.IsNullOrEmpty(eingabe))
                {
                    throw new MeineException();
                }

                int a = int.Parse(eingabe);
            }
            catch (FormatException ex)
            {
                //Schreibe den Fehler in eine Logatei ex.Message + ex.StackTrace

                throw new Exception("Bitte gebe eine Zahl ein");
            }
            catch (OverflowException ex)
            {
                //Schreibe den Fehler in eine Logatei ex.Message + ex.StackTrace
                throw new Exception("Bitte gebe eine Zahl zwischen -2.1Mrd und 2.1 Mrd ein");

            }
            finally
            {

            }
            

            Console.ReadKey();
        }
    }
}
