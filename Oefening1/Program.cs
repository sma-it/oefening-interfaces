using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opdracht:
            // Maak een lijst van IDrive objecten en voeg hier enkele Car en Bus instanties aan toe.
            // Gebruik een foreach lus om door de lijst te itereren en roep voor elk
            // object de StartEngine en Accelerate methoden aan.
            IList<IDrive> drives = new List<IDrive>();

            drives.Add(new Car());
            drives.Add(new Car());
            drives.Add(new Bus());

            foreach(var drive in drives)
            {
                drive.StartEngine();
                drive.Accelerate();
            }

            // einde programma
            Console.ReadLine();
        }
    }
}
