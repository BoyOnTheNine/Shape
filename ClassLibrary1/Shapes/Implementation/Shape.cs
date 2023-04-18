using System;
namespace ClassLibrary1.Shapes.Implementation
{
    public abstract class Shape
    {
        public virtual bool ValidateShapeData(List<double> sides, int expectedCount)
        {
            if (sides?.Count() != expectedCount)
            {
                return false;
            }

            foreach (var side in sides)
            {
                if (side <= 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
