using GeometricMath.Data;
using GeometricMath.Data.Entities;

namespace GeometricMath.Core
{
    public static class ShapeFactory
    {
        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public static IShape CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
    }
}
