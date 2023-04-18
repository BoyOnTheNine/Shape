namespace ClassLibrary1.Shapes.Interfaces
{
    /// <summary>
    /// IShape interface.
    /// </summary>
    public interface IShapeCalculatable
    {
        //Calculate shape area
        double CalculateArea(List<double> sides);
    }
}
