using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Shapes.GeometricShapes
{
    public class Cercle : Shapes
    {

        public Cercle(float Radius) : base()
        {
            Constants.Element.Add("Cercle");
            Name = "Cercle";
            Perimeter = Constants.Pi * 2 * Radius;
            Surface = Constants.Pi * Radius * Radius;
        }

        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }
}
