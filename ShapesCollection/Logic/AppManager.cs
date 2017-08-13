using ShapesCollection.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCollection.Logic
{
    
    public class AppManager
    {
        private Dictionary<int, Shape> _shapesCollection =  new Dictionary<int,Shape>();

        public void AddShape()
        {
            Shape test = new Circle(new Point(0, 0), 5);
            _shapesCollection.Add(1,test);
            Console.WriteLine("=> shape 1:" + test.Description());

        }

    }
}
