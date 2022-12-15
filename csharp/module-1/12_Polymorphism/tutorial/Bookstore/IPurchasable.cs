using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.Bookstore
{
    public interface IPurchasable
    {
        decimal Price { get; }
        //classes that implement Ipurchasable must have a getter for price

    }
}
