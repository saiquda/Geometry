using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Circle : IFigure
    {
        double r { get; }
        public Circle(double r)
        {
            this.r = r;
        }
        public double GetSquare()
        {
            return Math.PI * r * r;
        }
    }
}
