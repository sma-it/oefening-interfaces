using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    interface ICalculate
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);
    }
}
