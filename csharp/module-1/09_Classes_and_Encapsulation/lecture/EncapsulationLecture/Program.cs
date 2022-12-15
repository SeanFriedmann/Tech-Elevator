using System;
using EncapsulationLecture.Classes;

namespace EncapsulationLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person david = new Person(1989);//now you need to put the variable value inside the ()

            string dogName = "Jerry";
            //define properties on davids dog
            Dog davidsDog = new Dog("Shepard-Mix", dogName, false);
            Dog charliesDog = new Dog("Beagle", "Snoopy", false);

            //define what you want speak sound to be
            davidsDog.SpeakSound = "Ruff";
            charliesDog.SpeakSound = "aarf";

            //call speak on davids dog
            davidsDog.Speak();
            charliesDog.Speak();

            //switch between classes while debugging is very useful to see values of variables and output

            charliesDog.Speak("grr");

           // string charliesDogGreeting = charliesDog.GetReading();
            //Console.WriteLine(charliesDogGreeting);
            Console.WriteLine(charliesDog.GetReading());
            //Dog emptyDog = new Dog();
            
        }


    }
}
