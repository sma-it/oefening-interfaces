using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6
{
    internal class Athlete : IWalk, IJog, IRun
    {
        public void Jog()
        {
            Console.WriteLine("The athlete is jogging");
        }

        public void Run()
        {
            Console.WriteLine("The athlete is running");
        }

        public void Walk()
        {
            Console.WriteLine("The athlete is walking");
        }
    }
}
