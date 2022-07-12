using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Circle : IFigure
    {
        double r { get; }
        public Circle(double r)
        {
            if(r<=0)
                throw new ArgumentException("Неверно указан радиус");
            this.r = r;
        }
        public double GetSquare()
        {
            return Math.PI * r * r;
        }
    }
}
