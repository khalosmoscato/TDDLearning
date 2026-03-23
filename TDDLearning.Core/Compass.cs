using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDLearning.Core
{
    public class Compass
    {
        public Point CurrentPoint { get; private set; }
        public Compass(Point startPoint)
        {
            CurrentPoint = startPoint;
        }
        public Point Rotate(Point point, Direction direction) => (point, direction) switch
        {
            (Point.North, Direction.Right) => Point.East,
            (Point.East, Direction.Right) => Point.South,
            (Point.South, Direction.Right) => Point.West,
            (Point.West, Direction.Right) => Point.North,
        };
    }
}
