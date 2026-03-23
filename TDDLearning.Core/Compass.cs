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
            return Point.South;
        }
    }
}
