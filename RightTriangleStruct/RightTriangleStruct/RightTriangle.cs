using System;

namespace RightTriangleStruct
{
    public struct RightTriangle
    {
        private double a;
        public double A
        {
            get => a;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Длина катета A должна быть положительной");
                a = value;
            }
        }

        private double b;
        public double B
        {
            get => b;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Длина катета B должна быть положительной");
                b = value;
            }
        }

        public double Hypotenuse => Math.Sqrt(A * A + B * B);

        public RightTriangle(double a, double b) : this()
        {
            A = a;
            B = b;
        }

        public override string ToString() => $"Прямоугольный треугольник с катетами {A:F4} см и {B:F4} см";

        public override bool Equals(object obj)
        {
            if (obj is RightTriangle)
                return A == ((RightTriangle)obj).A && B == ((RightTriangle)obj).B; // Точное сравнение
            throw new ArgumentException("Объект не является прямоугольным треугольником");
        }

        public override int GetHashCode() => A.GetHashCode() ^ B.GetHashCode();

        public static RightTriangle operator *(double k, RightTriangle triangle)
        {
            if (k <= 0)
                throw new ArgumentException("Коэффициент должен быть положительным");
            return new RightTriangle(triangle.A * k, triangle.B * k);
        }

        public static RightTriangle operator *(RightTriangle triangle, double k) => k * triangle;
    }
}