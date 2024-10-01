using GeometricMath.Data;
using GeometricMath.Data.Entities;

namespace GeometricMath.Core
{
    public class ShapeManager
    {
        private readonly List<IShape> shapes = new List<IShape>();

        public void AddShape(IShape shape)
        {
            shapes.Add(shape);
        }

        public void CalculateAreas()
        {
            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Площадь фигуры: {shape.CalculateArea()}");
                if (shape is Triangle triangle && triangle.IsRightTriangle())
                    Console.WriteLine("Этот треугольник прямоугольный.");
            }
        }
    }
}
