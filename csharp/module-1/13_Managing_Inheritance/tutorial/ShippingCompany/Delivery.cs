using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingCompany
{
    public abstract class Delivery
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Distance { get; set; }
        public Shipment Shipment { get; set; }

        public abstract int GetDuraction();
        //the class neeeds to be abstract for this to function properly
        
        protected int ConvertHoursToMinutes(double decimalHours)
        {
            int hours = (int)decimalHours;
            int minutes = (int)Math.Round((decimalHours - hours) * 60);
            return (hours * 60) + minutes;
        }

        public DateTime GetExpectedArrival(DateTime departure)
        {
            return departure.AddMinutes(GetDuraction());
        }
    
    }
   
}
