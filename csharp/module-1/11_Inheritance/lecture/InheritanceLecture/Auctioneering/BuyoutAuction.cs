using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class BuyoutAuction : Auction //public allows us to use elsewhere
                                         // : Auction: will inherit data and behavior from auction
    {
        public BuyoutAuction(int buyoutPrice) : base() //calls base constructor first
        {
            this._buyoutPrice = buyoutPrice; //use backing field instead of public
        }

        //buyout price
        private int _buyoutPrice;

        //property of buyoutauction class
        public int BuyoutPrice 
        {
            get
            {
                return _buyoutPrice; //return the place the data lives
            }
        }
        //does not allow price to change once we set it, readonly

        public override bool PlaceBid(Bid offeredBid)
            //override allows us to override the parent (original Method)
            //checks to make sure the auction hasnt ended
        {
            //if buyout price is not met, run as normal auction
            bool newHighBid = base.PlaceBid(offeredBid);

            if (newHighBid && offeredBid.BidAmount >=  this.BuyoutPrice)
                //valid high bid and auction hasnt ended
            {
                Console.WriteLine($"Buyout met by {offeredBid.Bidder}.");
                base.EndAuction();

            }
            
            //if (Auction!= Null && ......)
            //this is auto false, null does not equal null

            return newHighBid;
        }

    }
}
