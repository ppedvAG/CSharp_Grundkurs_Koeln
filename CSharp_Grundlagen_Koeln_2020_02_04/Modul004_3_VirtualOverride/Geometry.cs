﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_3_VirtualOverride
{
    public class Shape
    {
        //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/virtual

        public const double PI = Math.PI;
        protected double x, y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return PI * x * x;
        }
    }

    public class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }

    public class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }

    public class Rechteck : Shape
    {
        public Rechteck(double x, double y)
            : base(x, y)
        {
        }
    }

    public class Quatrat : Shape
    {
        public Quatrat(double x, double y)
            : base(x, y)
        {
        }

        public override double Area()
        {
            return base.Area();
        }

        public override string ToString()
        {
            string meineSpezifischeAusgabe = $"Mein Quatrat hat ein X: {x} und ein Y: {y} und seine Fläche ist {Area()} ";
            return meineSpezifischeAusgabe;
        }
    }
}
