
namespace ShapesCollection.Classes
{
    public class Point
    {
        private double _x;
        private double _y;

        public double X
        {
            get
            {
                return _x;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
        }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}
