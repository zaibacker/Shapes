using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.GeometricShapes
{
    public class Shapes
    {
        public float Perimeter { get; set; }
        public float Surface { get; set; }
        public string Name { get; set; }

        public Shapes()
        {
        }

        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }
}
