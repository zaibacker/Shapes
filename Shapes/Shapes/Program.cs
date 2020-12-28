using Shapes.GeometricShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            var shapeCollections = Inizialization();

            Services.SortCollectionByPerimeterAsc(shapeCollections);

            var shapesSerializaed = Services.SerializationToJson(shapeCollections);
            
            Services.ElementElementing();
        }

        private static List<GeometricShapes.Shapes> Inizialization()
        {
            var shapeCollections = new List<GeometricShapes.Shapes>();

            var cercle1 = new Cercle(2.3f);
            var rectangle1 = new Rectangle(5.2f, 1.6f);
            var square1 = new Square(5.1f);
            var triangleEqui = new Triangle(3.0f, 3.0f, 3.0f);
            var triangleIsoscele = new Triangle(1.2f, 1.2f, 1.0f);
            var triangleScalene = new Triangle(1.4f, 5.2f, 1.7f);

            shapeCollections.Add(cercle1);
            shapeCollections.Add(rectangle1);
            shapeCollections.Add(triangleEqui);
            shapeCollections.Add(triangleIsoscele);
            shapeCollections.Add(triangleScalene);
            shapeCollections.Add(square1);

            return shapeCollections;
        }

    }
}
