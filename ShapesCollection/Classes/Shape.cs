
namespace ShapesCollection.Classes
{
    public abstract class Shape
    {
        protected Point _point;

        public Shape(Point point)
        {
            _point = point;
        }

        public virtual string Description()
        {
            return "Just a simple basic shape";
        }
    }
}
