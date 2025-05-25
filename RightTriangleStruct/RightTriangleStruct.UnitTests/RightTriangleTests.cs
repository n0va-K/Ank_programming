using NUnit.Framework;
using RightTriangleStruct;
using System;

namespace RightTriangleStruct.UnitTests
{
    [TestFixture]
    public class RightTriangleTests
    {
        [Test]
        public void Constructor_ValidParameters_PropertiesSetCorrectly()
        {
            var triangle = new RightTriangle(3, 4);
            Assert.That(triangle.A, Is.EqualTo(3));
            Assert.That(triangle.B, Is.EqualTo(4));
        }

        [TestCase(-1, 2)]
        [TestCase(3, -5)]
        public void Constructor_InvalidValues_ThrowsException(double a, double b)
        {
            Assert.That(() => new RightTriangle(a, b), Throws.ArgumentException);
        }

        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        public void Hypotenuse_ValidValues_CorrectResult( double a, double b, double expected)
        {
            var triangle = new RightTriangle(a, b);
            Assert.That(triangle.Hypotenuse, Is.EqualTo(expected));
        }

        [TestCase(3.5, 4.5, "Прямоугольный треугольник с катетами 3,5000 см и 4,5000 см")]
        [TestCase(0.1, 0.2, "Прямоугольный треугольник с катетами 0,1000 см и 0,2000 см")]
        public void ToStringTest(double a, double b, string expected)
        {
            var triangle = new RightTriangle(a, b);
            Assert.That(triangle.ToString(), Is.EqualTo(expected));
        }

        [TestCase(3, 4, 3, 4, true)]
        [TestCase(3, 4, 4, 3, false)]
        public void Equals_TwoTriangles_ExpectedResult(
            double a1, double b1, double a2, double b2, bool result)
        {
            var triangle1 = new RightTriangle(a1, b1);
            var triangle2 = new RightTriangle(a2, b2);
            Assert.That(triangle1.Equals(triangle2), Is.EqualTo(result));
        }

        [Test]
        public void GetHashCode_EqualTriangles_SameHash()
        {
            var triangle1 = new RightTriangle(3, 4);
            var triangle2 = new RightTriangle(3, 4);
            Assert.That(triangle1.GetHashCode(), 
                Is.EqualTo(triangle2.GetHashCode()));
        }

        [TestCase(2, 3, 4, 6, 8)]
        [TestCase(0.5, 6, 8, 3, 4)]
        public void MultiplicationTest(
            double k, double a, double b, double expectedA, double expectedB)
        {
            var triangle = new RightTriangle(a, b);
            var scaled = k * triangle;
            Assert.That(scaled.A, Is.EqualTo(expectedA));
            Assert.That(scaled.B, Is.EqualTo(expectedB));
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void Multiplication_InvalidCoefficient_ThrowsException(double k)
        {
            var triangle = new RightTriangle(3, 4);
            Assert.That(() => k * triangle, Throws.ArgumentException);
        }
    }
}