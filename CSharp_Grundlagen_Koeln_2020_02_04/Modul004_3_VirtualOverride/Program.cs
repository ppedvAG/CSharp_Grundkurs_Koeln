using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_3_VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();



            Circle circle = new Circle(8);
            Sphere sphere = new Sphere(9);
            Cylinder cylinder = new Cylinder(8, 5);

            Rechteck rechteck = new Rechteck(10, 5);
            Quatrat quatrat = new Quatrat(4, 4);

            double circleAreaResult = circle.Area();
            Console.WriteLine($"Ausgabe von eine Circle: {circleAreaResult}");

            double sphereAreaResult = sphere.Area();
            Console.WriteLine($"Ausgabe von eine Sphere: {sphereAreaResult}");

            double cylinderAreaResult = cylinder.Area();
            Console.WriteLine($"Ausgabe von eine Cylinder: {cylinderAreaResult}");

            double rechteckResult = rechteck.Area();
            Console.WriteLine($"Ausgabe von eine Rechteck: {rechteckResult}");

            double quatratResult = quatrat.Area();
            Console.WriteLine($"Ausgabe von einem Quatrat: {quatratResult}");
            Console.WriteLine($"{quatrat.ToString()}");

            Console.ReadKey();
        }
    }
}
