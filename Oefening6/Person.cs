using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6
{
    internal class Person : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("the person is walking");
        }
    }
}
