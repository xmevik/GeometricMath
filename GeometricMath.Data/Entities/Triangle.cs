namespace GeometricMath.Data.Entities
{
    public class Triangle : IShape
    {
        public double A {  get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalculateArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        // В задании нету четкого обещания, что стороны указываются в правильном порядке(A и B катеты, C гипотенуза)
        // Поэтому условие в любом случае сработает на прямоугольном треугольнике
        public bool IsRightTriangle()
        {
            return (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2)) || 
                   (Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2)) || 
                   (Math.Pow(C, 2) + Math.Pow(B, 2) == Math.Pow(A, 2));
        }
    }
}
