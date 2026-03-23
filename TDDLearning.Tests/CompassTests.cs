using System.Drawing;
using TDDLearning.Core;
using Point = TDDLearning.Core.Point;

namespace TDDLearning.Tests;

[TestFixture]
public class CompassTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(Description = "Rotating Right from North direction returns Point.East")]
    public void Rotate_NorthAndRight_ReturnsEast()
    {
        Compass compass = new Compass(Point.North);
        Point startPoint = Point.North;
        Direction direction = Direction.Right;

        Point result = compass.Rotate(startPoint, direction);
        Assert.That(result, Is.EqualTo(Point.East));
    }

    [Test]
    [TestCase(Description = "Rotating Right from all cardinal points")]
    public void AllPointsRight_ReturnsCorrectPoints()
    {
        Compass compass = new Compass (Point.North);
        Assert.Multiple(() =>
        {
            Assert.That(compass.Rotate(Point.North, Direction.Right), Is.EqualTo(Point.East));
            Assert.That(compass.Rotate(Point.East, Direction.Right), Is.EqualTo(Point.South));
            Assert.That(compass.Rotate(Point.South, Direction.Right), Is.EqualTo(Point.West));
            Assert.That(compass.Rotate(Point.West, Direction.Right), Is.EqualTo(Point.North));
        });
    }

    [Test]
    [TestCase(Description = "Rotating Left from all cardinal points")]
    public void AllPointsLeft_ReturnsCorrectPoints()
    {
        Compass compass = new Compass(Point.North);
        Assert.Multiple(() =>
        {
            Assert.That(compass.Rotate(Point.North, Direction.Left), Is.EqualTo(Point.West));
            Assert.That(compass.Rotate(Point.East, Direction.Left), Is.EqualTo(Point.North));
            Assert.That(compass.Rotate(Point.South, Direction.Left), Is.EqualTo(Point.East));
            Assert.That(compass.Rotate(Point.West, Direction.Left), Is.EqualTo(Point.South));
        });
    }
}
