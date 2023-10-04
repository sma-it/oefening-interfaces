using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            // opdracht:
            // Implementeer de interface IShape en de classes
            // Circle en Rectangle zodat de code hieronder werkt.
            // Verander niets aan de code hieronder.

            List<IShape> shapes = new List<IShape>();

            shapes.Add(new Circle(3));
            shapes.Add(new Rectangle(3, 4));
            shapes.Add(new Circle(5));

            double circumference = 0;
            double surface = 0;

            foreach(var shape in shapes)
            {
                circumference += shape.Circumference();
                surface += shape.Surface();
            }

            Console.WriteLine($"De totale omtrek is {circumference.ToString("0.##")}");
            Console.WriteLine($"De totale oppervlakte is {surface.ToString("0.##")}");

            Console.ReadLine();
        }
    }
}
