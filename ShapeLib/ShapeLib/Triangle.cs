using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib.Shapes
{
    public class Triangle : IShape
    {
        private double sideA { get; set; }
        private double sideB { get; set; }
        private double sideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Все стороны должны быть положительными числами");

            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Треугольник с такими сторонами не существует");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        private bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA)
                * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
