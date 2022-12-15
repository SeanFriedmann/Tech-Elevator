using Lecture.Farming; //to access isingable, cow, etc.
using System; //use console
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //

            //interface: contract for classes

            //need Name and Sound
            //FarmAnimal[] animals = new FarmAnimal[] { new Cow(), new Chicken(), new Pig() };
            ISingable[] singables = new ISingable[] { new Cow(), new Chicken(), new Pig(), new Tractor() };

            foreach (ISingable singable in singables)
            {
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + singable.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + singable.Sound + " " + singable.Sound + " here");
                Console.WriteLine("And a " + singable.Sound + " " + singable.Sound + " there");
                Console.WriteLine("Here a " + singable.Sound + " there a " + singable.Sound + " everywhere a " + singable.Sound + " " + singable.Sound);
                Console.WriteLine();
            }

            Console.WriteLine();
            //time to sell off the farm 
            ISellable[] sellables = new ISellable[] { new Egg(), new Cow(), new Pig(), new Chicken() };

            foreach (ISellable sellable in sellables)
            {
                Console.WriteLine($"Please buy this {sellable.Name} for only {sellable.Price.ToString("C")}!");
            }

            Console.WriteLine();
            Tractor myTractor = new Tractor();
            myTractor.Drive();
            Truck myTruck = new Truck();
            myTruck.Drive();

            List<IDriveable> vehicles = new List<IDriveable>();
            vehicles.Add(myTruck);
            vehicles.Add(myTractor);
            
        }
    }
}