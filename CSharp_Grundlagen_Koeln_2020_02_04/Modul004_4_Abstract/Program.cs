using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_4_Abstract
{
    public abstract class Shape
    {
        public abstract int GetArea();

        public virtual void TuWas()
        {
            Console.WriteLine("Ausgabe eines Shape Radiuses");
            return;
        }

        public void IchBinEineNormaleMethode()
        {

        }
    }

    public class Square : Shape
    {
        int side;

        public Square(int n)
        {
            side = n;
        }

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea()
        {
            return side * side;
        }

        public override void TuWas()
        {
            base.TuWas();
            Console.WriteLine("Überschriebene Methode Tu-Was");
        }
    }
    // Output: Area of the square = 144

    class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Shape(); -> Es ist nicht möglich von einer abstrakten Klasse ein Objekt zu bauen
            Square square = new Square(5);
            Console.WriteLine($"Fläche eines Quatrates: {square.GetArea()}");

        }
    }
}
