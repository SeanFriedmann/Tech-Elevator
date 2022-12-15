using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class SilentAuction : BuyoutAuction
        //pick one parent
    {
        public SilentAuction(int buyOutPrice):base(buyOutPrice)
        {

        }
    }
}
