using System;
using AreaLib.Figures.Base;

namespace AreaLib.Figures
{
    public class Circle : Figure
    {
        private readonly double radius;
        
        public Circle(string name, double radius)
            : base(name)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
