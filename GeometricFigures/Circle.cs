using System;

namespace GeometricFigures
{
    public class Circle : GeometricFigure
    {
        public double R { get; set; }

        public Circle(double r)
        {
            this.R = r;
        }

        public override double Area()
        {
            return Math.PI * this.R * this.R;
        }

        public override double PerimeterOrVolumen()
        {
            return Math.PI * this.R * 2;
        }

        public override string ToString()
        {
            return $"Circle\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Perimeter........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
