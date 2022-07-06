using System;

namespace Geometry
{
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public readonly bool isRectangular;
        public Triangle(double a, double b, double c)
        {
            double primetr = a + b + c;
            double maxSide = Math.Max(a, Math.Max(b, c));
            if (!((primetr - maxSide) - maxSide > 0))
                throw new ArgumentException("Большая сторона треугольника должна быть меньше суммы других сторон");

            if (a == Math.Sqrt(b * b + c * c) ||
                b == Math.Sqrt(a * a + c * c) ||
                c == Math.Sqrt(b * b + a * a))
                isRectangular = true;
            else
                isRectangular = false;
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
