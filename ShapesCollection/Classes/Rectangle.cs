using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCollection.Classes
{
    public class Rectangle : Shape
    {
        private double _firstSideLength, _secondSideLength;

        public Rectangle(Point corner, double firstSideLength, double secondSideLength)
            : base(corner)
        {
            _firstSideLength = firstSideLength;
            _secondSideLength = secondSideLength;
        }

        public override string Description()
        {
            string description = "rectangle with a corner at (" + _point.X + "," + _point.Y + ") and side lengths of " + 
                _firstSideLength + " and " + _secondSideLength;
            
            return description;
        }
    }
}
