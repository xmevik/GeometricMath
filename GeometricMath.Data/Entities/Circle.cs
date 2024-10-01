namespace GeometricMath.Data.Entities
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            if (Radius < 0)
                throw new ArgumentNullException("Radius can't be negative");

            return Math.PI * Radius * Radius;
        }
    }
}
