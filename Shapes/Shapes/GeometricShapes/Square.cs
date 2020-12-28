using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.GeometricShapes
{
    public class Square : Shapes
    {

        public Square(float Width) : base()
        {
            Constants.Element.Add(Constants.Square);
            Name = Constants.Square;
            Perimeter = Width * 4;
            Surface = Width * Width;
        }
    }
}
