namespace GeometricFigures
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var geometricFigures = new List<GeometricFigure>();

            var square = new Square(50);
            var rectangle = new Rectangle(50, 50);
            var parallelogram = new Parallelogram(50, 50, 50);
            var triangle = new Triangle(50, 50, 50, 50);
            var trapeze = new Trapeze(50, 50, 50, 50, 70);
            var circle = new Circle(50);
            var cube = new Cube(50);
            var cylinder = new Cylinder(50, 50);
            var cone = new Cone(50, 50, 50);
            var sphere = new Sphere(50);
            var regularTetrahedron = new RegularTetrahedron(50);

            geometricFigures.Add(square);
            geometricFigures.Add(rectangle);
            geometricFigures.Add(parallelogram);
            geometricFigures.Add(triangle);
            geometricFigures.Add(trapeze);
            geometricFigures.Add(circle);
            geometricFigures.Add(cube);
            geometricFigures.Add(cylinder);
            geometricFigures.Add(cone);
            geometricFigures.Add(sphere);
            geometricFigures.Add(regularTetrahedron);

            double totalArea = 0;
            double totalPerimeterOrVolume = 0;

            foreach (var geometricFigure in geometricFigures)
            {
                Console.WriteLine(geometricFigure);
                totalArea += geometricFigure.Area();
                totalPerimeterOrVolume += geometricFigure.PerimeterOrVolumen();
            }

            Console.WriteLine("==============================================");
            Console.WriteLine($"Total Area...............: {totalArea,15:N5}");
            Console.WriteLine($"Total Perimeter or Volume: {totalPerimeterOrVolume,15:N5}");
            Console.WriteLine("Press ENTER to finish...");
            Console.ReadKey();
        }
    }
}