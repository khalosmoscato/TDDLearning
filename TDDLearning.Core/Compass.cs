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
        public Point Rotate(Point point, Direction direction) 
        {

            if (point == Point.North && direction == Direction.Right) { return Point.East; }
            return Point.South;
        }
    }
}
