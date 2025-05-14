using ShapeLib.Shapes;

namespace ShapeLib.Test
{
    public class CircleTests
    {
        [Fact]
        public void CircleArea_WithValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle(5);
            double expected = Math.PI * 25;

            // Act
            double actual = circle.CalculateArea();

            // Assert
            Assert.Equal(expected, actual, 5);
        }

        [Fact]
        public void CircleCreation_WithNegativeRadius_ThrowsException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}