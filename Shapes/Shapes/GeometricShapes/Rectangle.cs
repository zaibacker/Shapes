using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.GeometricShapes
{
    public class Rectangle : Shapes
    {

        public Rectangle(float Width, float Lenght) : base()
        {
            Constants.Element.Add(Constants.Rectangle);
            Name = Constants.Rectangle;
            Perimeter = (Width + Lenght) * 2;
            Surface = Lenght * Width;
        }

    }
}
