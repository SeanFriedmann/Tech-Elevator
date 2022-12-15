using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public sealed class Cat : FarmAnimal
    {
        public override string Eat()
        {
            return "yum yum cat food!";
        }

        public Cat() : base("Cat", "meow")
        {

        
        }

        //public override string Sound
        //    //allows child to override parent property (Sound)
        //{
        //    get
        //    {
        //        return "meow";
        //    }
        //}
    }
}
