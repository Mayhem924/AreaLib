namespace AreaLib.Figures.Base
{
    public abstract class Figure
    {
        public string Name { get; private set; }
        
        public Figure(string name)
        {
            Name = name;
        }
        
        public abstract double GetArea();
    }
}