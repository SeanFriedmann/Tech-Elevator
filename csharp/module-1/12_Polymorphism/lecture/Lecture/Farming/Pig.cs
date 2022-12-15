using System;
using System.Collections.Generic;
using System.Text;
//namespace/ extensions
namespace Lecture.Farming
{

    //class
    public class Pig : FarmAnimal, ISellable //inherits from farm animal, and implemenets ISellable
    {
        public decimal Price { get; }

        //method
        public Pig() : base ("Pig", "oink")
        {
            this.Price = 60;
        }
    }
}
