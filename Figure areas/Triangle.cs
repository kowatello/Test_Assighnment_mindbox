using System.Diagnostics;

namespace Figure_areas
{
    /// <summary>
    /// Represents instance of a triangle
    /// </summary>
    public class Triangle : Figure
    {
        readonly double[] sides = new double[3];

        /// <summary>
        /// Creates a triangle by array of sides
        /// </summary>
        /// <param name="_sides">An array of three non-negative side lengths that defines a triangle</param>
        public Triangle(double[] _sides)
        {
            if (_sides.Length != 3)
                throw new ArgumentException("Wrong sides number");
            Array.Sort(_sides);
            if (_sides[0] < 0 || _sides[1] < 0 || _sides[2] < 0)
                throw new ArgumentException("Sides must have positive or 0 length");
            if (_sides[2] > _sides[1] + _sides[0])
                throw new ArgumentException("Impossible triangle: one side is bigger than other two combined");
            sides[0] = _sides[0];
            sides[1] = _sides[1];
            sides[2] = _sides[2];
        }

        /// <summary>
        /// Creates a triangle by set of 3 sides.
        /// </summary>
        /// <param name="side1">First side length. Needs to be positive or 0.</param>
        /// <param name="side2">Second side length. Needs to be positive or 0.</param>
        /// <param name="side3">Third side length. Needs to be positive or 0.</param>
        public Triangle(double side1, double side2, double side3) : this(new double[] { side1, side2, side3 })
        { }

        /// <summary>
        /// Calculates area of a triangle
        /// </summary>
        /// <returns>
        /// Area of a triangle.
        /// </returns>
        override public double Area()
        {
            var halfPerimeter = (sides[0] + sides[1] + sides[2]) / 2.0;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0]) * (halfPerimeter - sides[1]) * (halfPerimeter - sides[2]));
        }

        /// <summary>
        /// Checks if triangle is right
        /// </summary>
        /// <returns>
        /// True - for right triangle. 
        /// False - for non-right ordinaty triangle and zero- or flat triangle.
        /// </returns>
        public bool IsRight()
        {
            if (sides[0] == 0 || sides[1] == 0 || sides[2] == 0)
                return false;   
            if (sides[2] == sides[1] + sides[0])
                return false; 
            return (Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) <= Double.Epsilon);
        }
        
    }
}
