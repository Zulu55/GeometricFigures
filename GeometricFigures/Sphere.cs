namespace GeometricFigures
{
    using System;

    public class Sphere : Circle
    {
        public Sphere(double r) : base(r)
        {
        }

        public override double Area()
        {
            return 4 * Math.PI * this.R * this.R;
        }

        public override double PerimeterOrVolumen()
        {
            return 4.0 / 3.0 * Math.PI * this.R * this.R * this.R;
        }

        public override string ToString()
        {
            return $"Sphere\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Volume...........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
