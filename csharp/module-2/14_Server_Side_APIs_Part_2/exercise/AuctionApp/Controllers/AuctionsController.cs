using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao)
        {
            dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            Auction createdAuction = dao.Create(auction);
            return Created($"{createdAuction.Id}", createdAuction);
        }

        [HttpPut("{id}")]
        public ActionResult<Auction> UpdateAuction(int id, Auction updated)
        {
            Auction existingAuction = dao.Get(id);
            if (existingAuction == null) //if the reservation doesn't exist 
            {
                return NotFound(); //404
            }

            //do what you gotta do to update the thing
            Auction updatedAuction = dao.Update(existingAuction.Id, updated);

            return updatedAuction;
        }

        [HttpDelete("{id}")] // /reservations/:id 
        public ActionResult DeleteAuction(int id) //send back a untyped ActionResult since I will never be sending a reservation back
        {
            Auction existingAuction = dao.Get(id);
            if (existingAuction == null) //if the reservation doesn't exist 
            {
                return NotFound(); //404
            }

            bool result = dao.Delete(id);

            if (result) //if true (thing was deleted)
            {
                return NoContent(); //return 204 No Content 
            }
            else
            {
                return StatusCode(500);
            }


        }
    }
}
