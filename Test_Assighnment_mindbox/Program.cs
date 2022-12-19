using Figure_areas;

namespace Test_Assighnment_mindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(5, 7, 9);
            Console.WriteLine("{0}, {1}", triangle.Area(), triangle.IsRight());

            var circle = new Circle(1);
            Console.WriteLine("{0}", circle.Area());
        }
    }
}