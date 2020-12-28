using Newtonsoft.Json;
using Shapes.GeometricShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Shapes
{
    public static class Services
    {
        public static void SortCollectionByPerimeterAsc(IEnumerable<GeometricShapes.Shapes> shapes)
        {
            shapes = shapes.OrderBy(x => x.Perimeter);
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape name : {shape.Name} with Perimeter : {shape.Perimeter:0.00}");
            }
        }

        public static string SerializationToJson(IEnumerable<GeometricShapes.Shapes> shapes)
        {
            var json = JsonConvert.SerializeObject(shapes, new JsonSerializerSettings { FloatFormatHandling = FloatFormatHandling.DefaultValue});
            Console.WriteLine($"\nShapes serialized : {json}");
            return json;
        }

        public static void ElementElementing()
        {
            Console.WriteLine("\nTracking Shapes element in memory");

            var q = from x in Constants.Element
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };
            foreach (var x in q)
            {
                Console.WriteLine("Value: " + x.Value + " Element: " + x.Count);
            }

        }

    }
}
