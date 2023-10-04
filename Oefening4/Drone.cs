using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    internal class Drone : IFly, ISwim
    {
        public void Fly()
        {
            Console.WriteLine("The drone is flying");
        }

        public void Swim()
        {
            Console.WriteLine("The drone is swimming");
        }
    }
}
