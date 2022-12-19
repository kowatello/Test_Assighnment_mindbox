namespace Figure_areas
{
    public class Triangle : Figure
    {
        readonly double[] sides = new double[3];

        public Triangle(double[] _sides)
        {
            if (_sides.Length != 3)
            {
                throw new ArgumentException("Wrong sides number");
            }
            Array.Sort(_sides);
            if (_sides[0] < 0 || _sides[1] < 0 || _sides[2] < 0)
            {
                throw new ArgumentException("Sides must have positive or 0 length");
            }
            if (_sides[2] > _sides[1] + _sides[0])
            {
                throw new ArgumentException("Impossible triangle: one side is bigger than other two combined");
            }
            sides[0] = _sides[0];
            sides[1] = _sides[1];
            sides[2] = _sides[2];
        }

        public Triangle(double side1, double side2, double side3) : this(new double[] { side1, side2, side3 })
        { }

        override public double Area()
        {
            var halfPerimeter = (sides[0] + sides[1] + sides[2]) / 2.0;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0]) * (halfPerimeter - sides[1]) * (halfPerimeter - sides[2]));
        }

        public bool IsRight()
        {
            if (sides[0] == 0 && sides[1] == 0 && sides[2] == 0)
                return false;
            return (Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) <= Double.Epsilon);
        }
    }
}
