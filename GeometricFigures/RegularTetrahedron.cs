namespace GeometricFigures
{
    using System;

    public class RegularTetrahedron : Square
    {
        public RegularTetrahedron(double a) : base(a)
        {
        }

        public override double Area()
        {
            return this.A * this.A * Math.Sqrt(3);
        }

        public override double PerimeterOrVolumen()
        {
            return this.A * this.A * this.A * Math.Sqrt(2) / 12;
        }

        public override string ToString()
        {
            return $"Regular Tetrahedron\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Volume...........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
