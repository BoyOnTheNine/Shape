using ClassLibrary1.Shapes.Interfaces;

namespace ClassLibrary1.Shapes.Implementation
{
    public class Ciricle : Shape, IShapeCalculatable
    {
        private const int ExpectedSidesCount = 1;
        public double CalculateArea(List<double> sides)
        {
            if (!ValidateShapeData(sides, ExpectedSidesCount))
            {
                throw new ArgumentException("Count of sides for ciricle is not right.");
            }

            var radius = sides[0];

            return Math.PI * radius * radius;
        }
    }
}
