
namespace ShapesCollection.Classes
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(Point center, double radius)
            : base(center)
        {
            _radius = radius;
        }

        public override string Description()
        {
            string description = "circle with centre at (" + _point.X +"," + _point.Y + ") and radius " + _radius;
            return description;
        }
    }
}
