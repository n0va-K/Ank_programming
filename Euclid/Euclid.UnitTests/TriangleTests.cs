namespace Euclid.UnitTests
{
    public class TriangleTests
    {
        [Test]
        public void ConstructorTest() 
        { 
            var a = new Point(1, 1);
            var b = new Point(3, 1);
            var c = new Point(3, 4);

            var t = new Triangle(a, b, c);

            Assert.That(t.A, Is.EqualTo(a));
            Assert.That(t.B, Is.EqualTo(b));
            Assert.That(t.C, Is.EqualTo(c));
        }

        [Test]
        public void TestSideAB()
        {
            var t = CreateTestTriangle();

            Assert.That(t.AB.A.X, Is.EqualTo(1));
            Assert.That(t.AB.A.Y, Is.EqualTo(1));
            Assert.That(t.AB.B.X, Is.EqualTo(3));
            Assert.That(t.AB.B.Y, Is.EqualTo(1));
        }

        [Test]
        public void TestSideAC()
        {
            var t = CreateTestTriangle();

            Assert.That(t.AC.A.X, Is.EqualTo(1));
            Assert.That(t.AC.A.Y, Is.EqualTo(1));
            Assert.That(t.AC.B.X, Is.EqualTo(3));
            Assert.That(t.AC.B.Y, Is.EqualTo(4));
        }

        [Test]
        public void TestSideBC()
        {
            var t = CreateTestTriangle();

            Assert.That(t.BC.A.X, Is.EqualTo(3));
            Assert.That(t.BC.A.Y, Is.EqualTo(1));
            Assert.That(t.BC.B.X, Is.EqualTo(3));
            Assert.That(t.BC.B.Y, Is.EqualTo(4));
        }

        [Test]
        public void AreaTest()
        {
            var t = CreateTestTriangle();
            Assert.That(t.Area, Is.EqualTo(3).Within(Geometry.EPSILON));
        }

        private static Triangle CreateTestTriangle()
        {
            var a = new Point(1, 1);
            var b = new Point(3, 1);
            var c = new Point(3, 4);

            return new Triangle(a, b, c);
        }
    }
}
