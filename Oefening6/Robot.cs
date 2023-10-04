using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6
{
    internal class Robot : IWalk, IRun
    {
        public void Run()
        {
            Console.WriteLine("The robot is running");
        }

        public void Walk()
        {
            Console.WriteLine("The robot is walking");
        }
    }
}
