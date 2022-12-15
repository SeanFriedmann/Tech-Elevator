using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Egg : ISellable
    {
        public string Name { get; }
        public decimal Price { get; }

        public Egg()
        {
            this.Name = "Egg";
            this.Price = (decimal)0.25;
        }
    }
}
