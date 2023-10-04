using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Rectangle : IShape
    {
        int height;
        int width;

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public double Circumference()
        {
            return 2 * height + 2 * width;
        }

        public double Surface()
        {
            return height * width;
        }
    }
}
