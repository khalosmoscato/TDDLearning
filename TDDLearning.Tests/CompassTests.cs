using System.Drawing;
using TDDLearning.Core;
using Point = TDDLearning.Core.Point;

namespace TDDLearning.Tests;

public class CompassTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Rotate_NorthAndRight_ReturnsEast()
    {
        Compass compass = new Compass(Point.North);
        Point startPoint = Point.North;
        Direction direction = Direction.Right;

        Point result = compass.Rotate(startPoint, direction);
        Assert.That(result, Is.EqualTo(Point.East));
    }
}
