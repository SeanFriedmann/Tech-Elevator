using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.Classes
{
    public class Dog
    {
        //class is the blueprint
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        //auto format

        private bool isSpade { get; set; }

        private string speakSound;
        //backing field 
        //allow Dog to change sound, you dont know the noise until the Dog uses it
        public string SpeakSound
        {
            //get
            //{
            //    return speakSound;
            //}
            set
            {
                //value is the new data on assignment, keyword to hold data
                //need to set a private string to catch the data being entered
                this.speakSound = value; //allows us to change what the dog says
            }
        }

        //public Dog() //will not hit this breakpoint if you define variables in program
        //{
        //    Console.WriteLine("inside Dog constructor");
        //}


        //constructor with data
        public Dog(string breed, string name, bool isSpade)
        {
            //setup brand new dog with new variables
            //this: refers to current object, usually optional, allows you to specify the object you are working in, in this case Dog(Name)
            this.Name = name;
            Breed = breed;
            this.isSpade = isSpade; //this. specifies it is coming from the object Dog and not the constructor Dog
        }

        //cannot call objects from different projects in same solution

        //adding behaviors: things the Dog can do
        //this is called a method
        //method method method

        //Method overloading: 2 versions of the same method, different parameters
        //must have different number or types of parameters to overload

        public void Speak()
        {
            Console.WriteLine($"{this.Name} says {this.speakSound}");
        }

        public void Speak(string sound)
        {
            Console.WriteLine($"{this.Name} says {sound}");
        }

        public string GetReading()
        {
            return $"Hello {this.Name} you are a good doggo";
        }

    }
}
