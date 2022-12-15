using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingCompany
{
    public class AirDelivery : Delivery
    {
        private const int OneDayInMinutes = 24 * 60;
        public override int GetDuraction()
        {
            return OneDayInMinutes;
        }
    }
}
