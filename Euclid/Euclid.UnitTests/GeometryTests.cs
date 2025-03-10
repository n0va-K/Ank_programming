namespace Euclid.UnitTests
{
    public class GeometryTests
    {
        [Test]
        public void CreateSegment_DifferentPoints_Create()
        {
            var a = new Point(1, 1);
            var b = new Point(2, 3);

            var s = Geometry.CreateSegment(a, b);

            Assert.That(s.A, Is.EqualTo(a));
            Assert.That(s.B, Is.EqualTo(b));
        }

        [Test]
        public void CreateSegment_EqualPoints_ArgumentException()
        {
            var a = new Point(-2, 4);
            var b = new Point(-2, 4);

            //Assert.That(() => Geometry.CreateSegment(a, b), Throws.ArgumentException);

            var exception = Assert.Throws<ArgumentException>(() => Geometry.CreateSegment(a, b));
            Assert.That(exception.Message, Is.EqualTo("Концы отрезка совпадают"));
        }

        [TestCase(1, 1, true)]
        [TestCase(2, 3, true)]
        [TestCase(1.5, 2, true)]
        [TestCase(0, -1, false)]
        [TestCase(3, 3, false)]
        [TestCase(1, 2, false)]
        public void IsPointInsideSegmentTest(double x, double y, bool result)
        {
            var s = new Segment(new Point(1, 1), new Point(2, 3));
            var p = new Point(x, y);

            Assert.That(Geometry.IsPointInsideSegment(p, s), Is.EqualTo(result));
        }
    }
}
