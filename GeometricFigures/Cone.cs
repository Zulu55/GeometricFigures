namespace GeometricFigures
{
    using System;

    public class Cone : Cylinder
    {
        public double G { get; set; }

        public Cone(double r, double h, double g) : base(r, h)
        {
            this.G = g;
        }

        public override double Area()
        {
            return Math.PI * this.R * (this.G * this.R);
        }

        public override double PerimeterOrVolumen()
        {
            return 1.0 / 3.0 * Math.PI * this.R * this.R * this.H;
        }

        public override string ToString()
        {
            return $"Cone\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Volume...........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
