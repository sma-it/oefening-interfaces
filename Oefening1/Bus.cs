using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Bus : IDrive
    {
        public void StartEngine() => Console.WriteLine("Bus engine started.");
        public void StopEngine() => Console.WriteLine("Bus engine stopped.");
        public void Accelerate() => Console.WriteLine("Bus is accelerating.");
    }
}
