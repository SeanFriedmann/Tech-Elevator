using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingCompany
{
    public class TruckDelivery : Delivery
        //requires implementation of getduration()
    {
        public const double TruckTopSpeed = 60.0;
        public override int GetDuraction()
        {
            double decimalHours = (double)base.Distance / TruckTopSpeed;
            
            return ConvertHoursToMinutes(decimalHours); //duration in minutes

        }
    }
}
