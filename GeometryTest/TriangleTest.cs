using Geometry;
using NUnit.Framework;
using System;

namespace GeometryTest
{
    public class TriangleTest
    {

		public const double CalculationAccuracy = 1e-2;//Погрешность
		/// <summary>
		/// Error Test
		/// </summary>
		[TestCase(-1, 1, 1)]
		[TestCase(1, -1, 1)]
		[TestCase(1, 1, -1)]
		[TestCase(0, 0, 0)]
		public void InitTriangleWithErrorTest(double a, double b, double c)
		{
			Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
		}
		/// <summary>
		/// Initialize Test
		/// </summary>
		[TestCase(3, 4, 5)]
		[TestCase(4, 3, 5)]
		[TestCase(6, 8, 10)]
		[TestCase(8, 6, 10)]
		[Test]
		public void InitTriangleTest(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			Assert.NotNull(triangle);
			Assert.Less(Math.Abs(triangle.A - a), CalculationAccuracy);
			Assert.Less(Math.Abs(triangle.B - b), CalculationAccuracy);
			Assert.Less(Math.Abs(triangle.C - c), CalculationAccuracy);
		}
		/// <summary>
		/// Rectangular Triangle Test
		/// </summary>
		[TestCase(3, 4, 5)]
		[Test]
		public void GetRectangularTrSquareTest(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			var result = 6;
			var square = triangle.GetSquare();
			Assert.NotNull(square);
            Assert.Less(Math.Abs(square - result), CalculationAccuracy);
        }
		/// <summary>
		/// Acute Triangle Test
		/// </summary>
		[TestCase(5, 4, 4)]
		[Test]
		public void GetAcuteTrSquareTest(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			var result = 7.806;
			var square = triangle.GetSquare();
			Assert.NotNull(square);
            Assert.LessOrEqual(Math.Abs(square - result), CalculationAccuracy);
        }
		/// <summary>
		/// Obtuse Triangle Test
		/// </summary>
		[TestCase(7, 5, 10)]
		[Test]
		public void GetObtuseTrSquareTest(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			var result = 16.248;
			var square = triangle.GetSquare();
			Assert.NotNull(square);
            Assert.Less(Math.Abs(square - result), CalculationAccuracy);
        }
		/// <summary>
		/// Not Triangle Test
		/// </summary>
		[TestCase(9, 4, 5)]
		[TestCase(5, 3, 9)]
		[TestCase(2, 6, 3)]
		[TestCase(1, 3, 8)]
		[Test]
		public void InitNotTriangleTest(double a, double b, double c)
		{

			Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
		}
	}
}