namespace GeometricFigures
{
    using System;

    public class Cylinder : Circle
    {
        public double H { get; set; }

        public Cylinder(double r, double h) : base(r)
        {
            this.H = h;
        }
    
        public override double Area() 
        {
            return 2 * Math.PI * this.R * (this.H * this.R);
        }

        public override double PerimeterOrVolumen()
        {
            return Math.PI * this.R * this.R * this.H;
        }

        public override string ToString()
        {
            return $"Cylinder\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Volume...........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
