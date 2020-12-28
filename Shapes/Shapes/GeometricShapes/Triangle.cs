using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.GeometricShapes
{
    public class Triangle : Shapes
    {

        public Triangle(float X, float Y, float Z) : base()
        {
            // Check for equilateral triangle 
            if (X == Y && Y == Z)
                {
                    Name = "Equilateral "+Constants.Triangle;                  
                }

            // Check for isoceles triangle 
            else if (X == Y || Y == Z || Z == X)
            {
                Name =  "Isoceles " + Constants.Triangle;
            }

            // Otherwise scalene triangle 
            else
            {
                Name = "Scalene " + Constants.Triangle; ;
            }

            Constants.Element.Add(Constants.Triangle);
            Perimeter = X + Y + Z;
            Surface = (float)Area((float)X, (float)Y, (float)Z) ;
        }

        private double Area(float a, float b, float c) //Area calculations
        {
            float s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

    }
}
