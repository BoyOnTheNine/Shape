using ClassLibrary1.Shapes.Implementation;

namespace ShapeTest
{
    public class ShapeTests
    {
        [Test]
        public void CircleAreaTest()
        {
            // Arrange
            var radius = 3;
            var expectedArea = 28.274;
            var ciricle = new Ciricle();

            // Act
            var actualArea = ciricle.CalculateArea(new List<double> { radius});

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.001));
        }

        [Test]
        public void RightTriangleAreaTest()
        {
            // Arrange
            var a = 3;
            var b = 4;
            var c = 5;
            var expectedArea = 6;
            var trianle = new Triangle();

            // Act
            var actualArea = trianle.CalculateArea(new List<double> { a, b, c});

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        public void SimpleTriangleAreaTest()
        {
            // Arrange
            var a = 10;
            var b = 4;
            var c = 12;
            var expectedArea = 18.735;
            var trianle = new Triangle();

            // Act
            var actualArea = trianle.CalculateArea(new List<double> { a, b, c });

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.001));
        }
    }
}