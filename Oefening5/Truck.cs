using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    internal class Truck : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("The truck is driving");
        }
    }
}
