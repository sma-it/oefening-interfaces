using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    internal class Car : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }
    }
}
