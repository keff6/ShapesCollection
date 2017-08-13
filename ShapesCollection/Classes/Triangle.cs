using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCollection.Classes
{
    public class Triangle : Shape
    {
        private double _vertex1_x, _vertex1_y, _vertex2_x, _vertex2_y;

        public Triangle(Point vertex0, double vert1_x, double vert1_y, double vert2_x, double vert2_y)
            : base(vertex0)
        {
            _vertex1_x = vert1_x;
            _vertex1_y = vert1_y;
            _vertex2_x = vert2_x;
            _vertex2_y = vert2_y;
        }

        public override string Description()
        {
            string description = "triangle with vertex at (" + _point.X + "," + _point.Y + "), " +
                                    "(" + _vertex1_x + "," + _vertex1_y + ") and " +
                                    "(" + _vertex2_x + "," + _vertex2_y + ")";
            return description;
        }
    }
}
