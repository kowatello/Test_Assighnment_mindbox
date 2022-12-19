namespace Figure_areas
{
    public class Circle : Figure
    {
        readonly double radius;

        public Circle(double _radius)
        {
            if (_radius < 0)
                throw new ArgumentException("Circle radius must be positive or 0");
            radius = _radius;
        }

        override public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
