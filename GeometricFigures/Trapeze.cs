namespace GeometricFigures
{
    public class Trapeze : Triangle
    {
        public double B2 { get; set; }

        public Trapeze(double a, double b, double c, double h, double b2) : base(a, b, c, h)
        {
            this.B2 = b2;
        }

        public override double Area()
        {
            return (this.B2 + this.B) * this.H / 2;
        }

        public override double PerimeterOrVolumen()
        {
            return this.B2 + this.B + this.A + this.C;
        }

        public override string ToString()
        {
            return $"Trapeze\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Perimeter........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
