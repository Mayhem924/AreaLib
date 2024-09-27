using AreaLib.Figures.Base;

namespace AreaLib
{
    public class AreaCalculator : IAreaCalculator
    {
        public double GetArea(Figure figure)
        {
            return figure.GetArea();
        }
    }
}