using System;

namespace Geometry
{
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public Triangle(double a, double b, double c)
        {
            double sides = a + b + c;
            double maxSide = Math.Max(a, Math.Max(b, c));
            if (!((sides - maxSide) - maxSide > 0))
                throw new ArgumentException("Большая сторона треугольника должна быть меньше суммы других сторон");
            else
            {
                if (a == Math.Sqrt(b * b + c * c) || b == Math.Sqrt(a * a + c * c) || c == Math.Sqrt(b * b + a * a))
                {
                    this.A = a;
                    this.B = b;
                    this.C = c;
                }
                else
                    throw new ArgumentException("Треугольник непрямоугольный.");
            }
        }
        public double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
