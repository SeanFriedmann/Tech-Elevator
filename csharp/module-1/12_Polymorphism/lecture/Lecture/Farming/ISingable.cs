using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISingable //something we can sing about
    {
        //cannot be instantiated, do not make objects
        //no constructor
        string Name { get; }
        string Sound { get; }


    }
}
