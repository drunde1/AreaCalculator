namespace AreaCalculator
{
    public class Circle : IFigure
    {
        private double _radius= 0;
        public Circle(double R)
        {
            _radius = R;
        }
        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
