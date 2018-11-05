namespace GeometricFigures
{
    public class Rectangle : Square
    {
        public double B { get; set; }

        public Rectangle(double a,double b) : base(a)
        {
            this.B = b;
        }

        public override double Area()
        {
            return this.A * this.B;
        }

        public override double PerimeterOrVolumen()
        {
            return this.Area() * 2;
        }

        public override string ToString()
        {
            return $"Rectangle\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Perimeter........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
