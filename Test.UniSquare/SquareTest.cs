namespace Test.UniSquare
{
    public class SquareTest
    {
        [Fact]
        public void TriangleSidesTest()
        {
            var tri = new Triangle(12.4, 5.6, 8.2);
            var exp = 18.357;
            Assert.Equal(exp, Math.Round(tri.GetSquare(), 3));
            tri.SetSides(10,5,7);
            exp = 16.248;
            Assert.Equal(exp, Math.Round(tri.GetSquare(), 3));
        }

        [Fact]
        public void TriangleHeightTest() 
        {
            var tri = new Triangle(14.6, 23);
            var exp = 167.9;
            Assert.Equal(exp, tri.GetSquare());
            tri.SetHeightAndBase(16,13);
            exp = 104;
            Assert.Equal(exp, tri.GetSquare());
        }

        [Fact]
        public void TriangleRectangularTest()
        {
            var tri = new Triangle(3, 4, 5);
            Assert.True(tri.IsRectangular());
            var exp = 6;
            Assert.Equal(exp, tri.GetSquare());
        }

        [Fact]
        public void TrianglePointsTest()
        {
            var tri = new Triangle();
            tri.SetPoints(
                new List<Point>
                {
                    new Point(4,8),
                    new Point(3,7),
                    new Point(7,15),
                }
                );
            var exp = 2;
            Assert.Equal(exp, tri.GetPointsSquare());
            Assert.Throws<Exception>(()=>tri.SetPoints(
                new List<Point>
                {
                    new Point(4,8),
                    new Point(3,7),
                    new Point(7,15),
                    new Point(9,12),
                }
                ));

        }

        [Fact]
        public void CircleTest()
        {
            var cir = new Circle(25.2);
            var exp = 1995.037;
            Assert.Equal(exp, cir.GetSquare());
        }

        [Fact]
        public void PolygonTest()
        {
            var pol = new Polygon();
            pol.SetPoints(
                new List<Point>
                {
                    new Point(4,8),
                    new Point(3,7),
                    new Point(7,15),
                    new Point(9,12),
                }
                );
            var exp = 13.5;
            Assert.Equal(exp, pol.GetSquare());
        }
    }
}