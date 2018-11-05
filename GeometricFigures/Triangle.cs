namespace GeometricFigures
{
    public class Triangle : Parallelogram
    {
        public double C { get; set; }

        public Triangle(double a, double b, double c, double h) : base(a, b, h)
        {
            this.C = c;
        }

        public override double Area()
        {
            return this.B * this.H / 2;
        }

        public override double PerimeterOrVolumen()
        {
            return this.A + this.B + this.C;
        }

        public override string ToString()
        {
            return $"Triangle\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Perimeter........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
