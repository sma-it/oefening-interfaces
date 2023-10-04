using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    class Program
    {
        // opdracht:
        // maak twee interfaces, IFly en ISwim. 

        // IFly krijgt een functie Fly
        // ISwim krijgt een functie Swim

        // Creëer een klasse Drone die beide interfaces implementeert.
        // Laat de methoden simpelweg een relevante tekst afdrukken naar de console.
        
        // Welke lijnen code hieronder werken niet?   
        // Waarom?

        static void Main(string[] args)
        {
            Drone drone1 = new Drone();
            drone1.Fly();
            drone1.Swim();

            IFly drone2 = new Drone();
            drone2.Fly();
            drone2.Swim();

            ISwim drone3 = new Drone();
            drone3.Fly();
            drone3.Swim();

            Console.ReadLine();
        }
    }
}
