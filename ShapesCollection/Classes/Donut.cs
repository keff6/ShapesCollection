using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCollection.Classes
{
    public class Donut : Shape
    {
        private double _radius1, _radius2;

        public Donut(Point center, double radius1, double radius2)
            : base(center)
        {
            _radius1 = radius1;
            _radius2 = radius2;
        }

        public override string Description()
        {
            string description = "donut with centre at (" + _point.X +"," + _point.Y + ") and radiuses of " + 
                _radius1 + " and "+ _radius2;
            return description;
        }
    }
}
