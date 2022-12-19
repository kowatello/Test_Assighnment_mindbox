namespace Figure_areas.Tests
{
    [TestClass]
    public class FigureAreasTest
    {
        void TestTriangleArea(double[] testSides, double exprxtedArea)
        {
            var triangle = new Triangle(testSides);
            var area = triangle.Area();

            Assert.AreEqual(exprxtedArea, area);
        }

        void TestTriangleRightness(double[] testSides, bool expectedRightness)
        {
            var triangle = new Triangle(testSides);

            Assert.AreEqual(expectedRightness, triangle.IsRight());
        }

        [TestMethod]
        public void OrdinaryTriangleArea()
        {
            TestTriangleArea(new double[] { 5.0, 7.0, 9.0 }, 17.41228014936585);
        }

        [TestMethod]
        public void ZeroTriangleArea()
        {
            TestTriangleArea(new double[] { 0.0, 0.0, 0.0 }, 0);
        }

        [TestMethod]
        public void InLineTriangleArea()
        {
            TestTriangleArea(new double[] { 1.0, 2.0, 1.0 }, 0);
        }

        [TestMethod]
        public void OrdinaryRightTriangle()
        {
            TestTriangleRightness(new double[] { 3.0, 4.0, 5.0 }, true);
        }

        [TestMethod]
        public void OrdinaryNotRightTriangle()
        {
            TestTriangleRightness(new double[] { 7.0, 2.0, 6.0 }, false);
        }

        [TestMethod]
        public void ZeroTriangleRightness()
        {
            TestTriangleRightness(new double[] { 0.0, 0.0, 0.0 }, false);
        }

        [TestMethod]
        public void InLineTriangleRightness()
        {
            TestTriangleRightness(new double[] { 2.0, 5.0, 3.0 }, true);
        }
    }
}