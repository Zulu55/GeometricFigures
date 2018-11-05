namespace GeometricFigures
{
    public class Square : GeometricFigure
    {
        public double A { get; set; }

        public Square(double a)
        {
            this.A = a;
        }

        public override double Area()
        {
            return this.A * this.A;
        }

        public override double PerimeterOrVolumen()
        {
            return this.A * 4;
        }

        public override string ToString()
        {
            return $"Square\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Perimeter........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}