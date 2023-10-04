using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class Program
    {
        // Stap 1: Creëer een interface IDrive met een methode Drive().

        // Stap 2: Creëer drie klassen: Car, Truck, en Bicycle.
        // Laat ze allemaal IDrive implementeren met een gepaste Drive() implementatie.

        // Stap 3: Zorg dat de functie hieronder een lijst met IDrive objecten accepteert
        // en voor bij elk object de drive functie uit. Onthoudt dat deze functie niet weet
        // welke class deze objecten hebben.
        
        static void DriveAll(IList<IDrive> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }
        }

        // Stap 4: Maak in main een lijst met IDrive objecten van verschillende classes.
        // Voor daarna de DriveAll functie uit met die lijst als argument.

        static void Main(string[] args)
        {
            List<IDrive> vehicles = new List<IDrive>();
            vehicles.Add(new Car());
            vehicles.Add(new Truck());
            vehicles.Add(new Bycicle());

            DriveAll(vehicles);

            Console.ReadLine();
        }
    }
}
