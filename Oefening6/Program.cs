using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6
{
    // Stap 1: Maak een class Person die IWalk implementeert
    // Stap 2: Maak een class Athlete die IWalk, IRun en IJog implementeert
    // Stap 3: Maak een class Robot die IWalk en IRun implementeert

    class Program
    {
        static void Main(string[] args)
        {
            // Stap 4: Vervang het object Person door Athlete en Robot
            // Observeer hoe dit de uitvoer van het programma verandert

            var x = new Person();

            if (x is IWalk)
            {
                (x as IWalk).Walk();
            }

            if (x is IJog)
            {
                (x as IJog).Jog();
            }

            if (x is IRun)
            {
                (x as IRun).Run();
            }

            Console.ReadLine();
        }
    }
}
