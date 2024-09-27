using System;
using AreaLib.Figures.Base;

namespace AreaLib.Figures
{
    public class Triangle : Figure
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(string name, double a, double b, double c) 
            : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            var p = (a + b + c) / 2d;
            var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
            return area;
        }

        public bool CheckRightTriangle()
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)
                || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2)
                || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2);
        }
    }
}
