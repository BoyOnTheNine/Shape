using ClassLibrary1.Shapes.Interfaces;

namespace ClassLibrary1.Shapes.Implementation
{
    public class Triangle : Shape, IShapeCalculatable
    {
        private const int  ExpectedSidesCount = 3;

        public double CalculateArea(List<double> sides)
        {
            if (!ValidateShapeData(sides, ExpectedSidesCount))
            {
                throw new ArgumentException("Count of sides for triangle is not right.");
            }

            if (IsRightTriangle(sides))
            {
                return RightTriangleFormula(sides);
            }

            return HeronFormula(sides);
        }

        private double RightTriangleFormula(List<double> sides) => (sides[0] * sides[1]) * 0.5;

        private bool IsRightTriangle(List<double> sides)
        {
            sides.Sort();
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }

        private double HeronFormula(List<double> sides)
        {
            var p = (sides[0] + sides[1] + sides[2]) * 0.5;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }
    }
}
