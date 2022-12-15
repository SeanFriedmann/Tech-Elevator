using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable, IDriveable //add name of interface
    {
        public string Name { get; }
        public string Sound { get; }
        public Tractor()
        {
            this.Name = "Tractor";
            this.Sound = "vroom";
        }

        public void Drive()
        {
            Console.WriteLine("Fire it up and play 'She Thinks my Tractors Sexy'!");
        }
    }
}
