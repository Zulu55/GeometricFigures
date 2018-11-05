namespace GeometricFigures
{
    public class Parallelogram : Rectangle
    {
        public double H { get; set; }

        public Parallelogram(double a, double b, double h) : base(a, b)
        {
            this.H = h;
        }

        public override double Area()
        {
            return this.H * this.B;
        }

        public override double PerimeterOrVolumen()
        {
            return (this.A + this.B) * 2;
        }

        public override string ToString()
        {
            return $"Parallelogram\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Perimeter........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
