using ClassLibrary1.Shapes;
using ClassLibrary1.Shapes.Interfaces;

namespace ClassLibrary1
{
    public interface IShapeFactory
    {
        IShapeCalculatable CreateShape(ShapeTypes shapeType);
    }
}
