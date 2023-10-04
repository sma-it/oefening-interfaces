using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Car : IDrive
    {
        public void StartEngine() => Console.WriteLine("Car engine started.");
        public void StopEngine() => Console.WriteLine("Car engine stopped.");
        public void Accelerate() => Console.WriteLine("Car is accelerating.");
    }
}
