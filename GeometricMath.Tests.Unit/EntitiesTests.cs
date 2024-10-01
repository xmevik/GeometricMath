using GeometricMath.Data.Entities;

namespace GeometricMath.Tests.Unit
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.PI * 5 * 5, area);
        }

        [TestMethod]
        public void CalculateArea_ZeroRadius_Zero()
        {
            // Arrange
            var circle = new Circle(0);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void CalculateArea_NegativeRadius_ThrowsException()
        {
            // Arrange
            var circle = new Circle(-5);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => circle.CalculateArea());
        }

        [TestMethod]
        public void CalculateArea_LargeRadius_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle(1000000);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.PI * 1000000 * 1000000, area);
        }

    }

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void CalculateArea_ZeroSides_Zero()
        {
            // Arrange
            var triangle = new Triangle(0, 0, 0);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void IsRightTriangle_Sides_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(true, isRightTriangle);
        }

        [TestMethod]
        public void IsRightTriangle_InvalidSides_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 3, 3);

            // Act
            var isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.AreEqual(false, isRightTriangle);
        }
    }


}
