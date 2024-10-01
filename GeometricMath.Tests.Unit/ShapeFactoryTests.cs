using GeometricMath.Core;
using GeometricMath.Data;
using GeometricMath.Data.Entities;

namespace GeometricMath.Tests.Unit
{
    [TestClass]
    public class ShapeFactoryTests
    {
        [TestMethod]
        public void CreateCircle_WithValidRadius_ReturnsCircle()
        {
            // Arrange
            double radius = 5;
            IShape expected = new Circle(radius);

            // Act
            IShape actual = ShapeFactory.CreateCircle(radius);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void CreateTriangle_WithValidSides_ReturnsTriangle()
        {
            // Arrange
            double a = 3, b = 4, c = 5;
            IShape expected = new Triangle(a, b, c);

            // Act
            IShape actual = ShapeFactory.CreateTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}