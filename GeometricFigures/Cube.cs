namespace GeometricFigures
{
    public class Cube : Square
    {
        public Cube(double a) : base(a)
        {
        }

        public override double Area()
        {
            return this.A * this.A * 6;
        }

        public override double PerimeterOrVolumen()
        {
            return this.A * this.A * this.A;
        }

        public override string ToString()
        {
            return $"Cube\n\t" +
                $"Area.............: {this.Area(),15:N5}\n\t" +
                $"Volume...........: {this.PerimeterOrVolumen(),15:N5}";
        }
    }
}
