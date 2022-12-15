using System;
using System.Collections.Generic;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a general auction.
    /// </summary>
    public class Auction
    {
       
        /// <summary>
        /// This is an encapsulated field that holds all placed bids.
        /// </summary>
        private List<Bid> allBids = new List<Bid>();

        /// <summary>
        /// Represents the current high bid.
        /// </summary>
        public Bid CurrentHighBid { get; private set; } = new Bid("", 0);

        /// <summary>
        /// All placed bids returned as an array.
        /// </summary>
        public Bid[] AllBids
        {
            get { return allBids.ToArray(); }
        }
        //printout of all bids
        //get/ readonly


        /// <summary>
        /// Indicates if the auction has ended yet.
        /// </summary>
        public bool HasEnded { get; private set; }

        /// <summary>
        /// Places a Bid on the Auction
        /// </summary>
        /// <param name="offeredBid">The bid to place.</param>
        /// <returns>True if the new bid is the current winning bid</returns>
        /// 
        
        public virtual bool PlaceBid(Bid offeredBid)
            //virtual: allows child classes to override 
        {
            //only accept bids if auction is ongoing



            bool newHighBidPlaced = false;
            // Print out the bid details.
            //bidder name + amount in currency format
            Console.WriteLine(offeredBid.Bidder + " bid " + offeredBid.BidAmount.ToString("C"));

            if (HasEnded == false) //or (!HasEnded)
            {

                // Record it as a bid by adding it to allBids
                allBids.Add(offeredBid);
                //add bid to list of bids


                // Check to see IF the offered bid is higher than the current bid amount
                // if yes, set offered bid as the current high bid
                if (offeredBid.BidAmount > CurrentHighBid.BidAmount) //offered bid is an object with 2 details
                {
                    CurrentHighBid = offeredBid;
                    newHighBidPlaced = true;
                }
            }
            else
            {
                Console.WriteLine("Auction has ended, no longer accepting bids.");
            }

            // Output the current high bid
            Console.WriteLine($"Current high bid is {CurrentHighBid.BidAmount.ToString("C")} by {CurrentHighBid.Bidder}!");
            // Return if this is the new highest bid
            return newHighBidPlaced;
        }

        //end the auction
        //announce the winner
        //TODO: stop accepting bids once auction ends
        public void EndAuction()
        {
            HasEnded = true;
            Console.WriteLine($"Auction has finished, {CurrentHighBid.Bidder} is the winner with a {CurrentHighBid.BidAmount.ToString("C")} bid.");
        }

        //METHODS: parameters, return type, meaningful name, access modifier


    }
}
