using ClassLibrary1.Shapes;
using ClassLibrary1.Shapes.Implementation;
using ClassLibrary1.Shapes.Interfaces;

namespace ClassLibrary1
{
    public class ShapeFactory : IShapeFactory
    {
        private Dictionary<ShapeTypes, IShapeCalculatable> _shapesCollections = new Dictionary<ShapeTypes, IShapeCalculatable>
        {
            { ShapeTypes.Ciricle, new Ciricle() },
            { ShapeTypes.Triangle, new Triangle() },

        };

        public IShapeCalculatable CreateShape(ShapeTypes shapeType)
        {
           _shapesCollections.TryGetValue(shapeType, out var shape);

            if (shape == null)
            {
                throw new ArgumentException($"Shape {shapeType} not found.");
            }

            return shape;
        }
    }
}