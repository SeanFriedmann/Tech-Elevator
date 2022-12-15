using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class ReserveAuction : Auction
        //throw public on class
        //add : Auction to gain access to all auction data and behaviors
    {
        //add property of low price
        private int _reservePrice;
       public int ReservePrice
        {
            get
            {
                return _reservePrice;
            }
        }

        //add constructor 
       public ReserveAuction (int reservePrice) : base()
        {
            this._reservePrice = reservePrice;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            //check to make sure offered bid is greater than reservePrice
            if (offeredBid.BidAmount >= this.ReservePrice)
            {
                Console.WriteLine("Reserve amount has been met.");
                return base.PlaceBid(offeredBid);
            }
            else
            {
                Console.WriteLine($"Reserve price not met. Price is {ReservePrice.ToString("C")}.");
              
            }
            return false;
        }
        }
}
