using ShapeLib.Shapes;

namespace ShapeLib.Test
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleArea_WithValidSides_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            double expected = 6;

            // Act
            double actual = triangle.CalculateArea();

            // Assert
            Assert.Equal(expected, actual, 5);
        }

        [Fact]
        public void TriangleCreation_WithInvalidSides_ThrowsException()
        {
            // Arrange Act  Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
        }

        [Fact]
        public void IsRightAngled_WithRightAngled_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(13, 12, 5);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }

        [Fact]
        public void IsRightAngled_WithNonRightAngled_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.False(isRightAngled);
        }
    }
}
