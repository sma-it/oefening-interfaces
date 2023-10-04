using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Circle : IShape
    {
        int radius;

        public Circle(int radius) { this.radius = radius; }

        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }

        public double Surface()
        {
            return Math.PI * Math.Pow(radius, 2); 
        }
    }
}
