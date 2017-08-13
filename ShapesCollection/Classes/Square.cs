using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCollection.Classes
{
    public class Square : Shape
    {
        private double _sideLength;

        public Square(Point corner, double sideLength)
            : base(corner)
        {
            _sideLength = sideLength;
        }

        public override string Description()
        {
            string description = "square with a corner at (" + _point.X + "," + _point.Y + ") and side length of " + _sideLength;
            return description;
        }
    }
}
