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
}
