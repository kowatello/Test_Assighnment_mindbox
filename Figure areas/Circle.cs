namespace Figure_areas
{
    /// <summary>
    /// Represents instance of a Circle
    /// </summary>
    public class Circle : Figure
    {
        readonly double radius;

        /// <summary>
        /// Creates a circle by its radius
        /// </summary>
        /// <param name="_radius">Radius of a circle. Needs to be positive or 0</param>
        public Circle(double _radius)
        {
            if (_radius < 0)
                throw new ArgumentException("Circle radius must be positive or 0");
            radius = _radius;
        }

        /// <summary>
        /// Calculates area of a circle
        /// </summary>
        /// <returns>
        /// Area of a circle
        /// </returns>
        override public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
