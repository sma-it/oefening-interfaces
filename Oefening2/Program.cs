using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            // opdracht:
            // - Implementeer de klasse genaamd BasicCalculator die de
            //   ICalculate interface gebruikt.
            // - Zorg ervoor dat elke methode in de klasse een simpele wiskundige
            //   berekening uitvoert conform de naam van de methode.

            ICalculate calculator = new BasicCalculator();
            int a = 8;
            int b = 4;

            Console.WriteLine($"{a} + {b} = {calculator.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {calculator.Subtract(a, b)}");
            Console.WriteLine($"{a} * {b} = {calculator.Multiply(a, b)}");
            Console.WriteLine($"{a} / {b} = {calculator.Divide(a, b)}");

            Console.ReadLine();
        }
    }
}
