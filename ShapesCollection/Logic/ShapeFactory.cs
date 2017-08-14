using ShapesCollection.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCollection.Logic
{
    public static class ShapeFactory
    {
        public static Shape MakeNewShape(string type, double[] values)
        {
            Shape newShape = null;

            Point shapeOrigin = new Point(values[0],values[1]);

            switch(type){
                case Constants.Circle:
                    newShape = new Circle(shapeOrigin, values[2]);
                    break;
                case Constants.Square:
                    newShape = new Square(shapeOrigin, values[2]);
                    break;
                case Constants.Rectangle:
                    newShape = new Rectangle(shapeOrigin, values[2], values[3]);
                    break;
                case Constants.Donut:
                    newShape = new Donut(shapeOrigin, values[2], values[3]);
                    break;
                case Constants.Triangle:
                    newShape = new Circle(shapeOrigin, values[2]);
                    break;
                case Constants.Ellipse:
                    newShape = new Circle(shapeOrigin, values[2]);
                    break;
                default:
                    break;
            }

            return newShape;
        }
    }
}
