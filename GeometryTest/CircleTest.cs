using Geometry;
using NUnit.Framework;
using System;

namespace GeometryTest
{
    public class CircleTest
    {
        public const double CalculationAccuracy = 1e-6;//Погрешность
        
        [TestCase(0)]
        [TestCase(-1)]
        public void InitCircleWithErrorTest(double r)
        {
            Assert.Catch<ArgumentException>(() => new Circle(r));
        }

        [TestCase(12.67)]
        [Test]
        public void GetSquareTest(double r)
        {
            var circle = new Circle(r);
            var expectedValue = 504.316413;

            var square = circle.GetSquare();

            Assert.Less(Math.Abs(square - expectedValue), CalculationAccuracy);
        }
    }
}