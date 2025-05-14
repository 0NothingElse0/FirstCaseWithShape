namespace ShapeLib.Shapes
{
    public class Circle : IShape
    {
        private double radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0");

            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
