using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc; //framework to use WEB APIs
using HotelReservations.Models;
using HotelReservations.DAO;

namespace HotelReservations.Controllers
{
    [Route("hotels")] //route attribute, defines location of the controller ("localhost:5001/hotels or 44322", its in launchSettings.json)
    [ApiController] //this is an API controller, specifies certain data for it
    public class HotelsController : ControllerBase
    {
        private static IHotelDao hotelDao;

        public HotelsController() //constructor
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao(); //dao for the hotels 
            }
        }

        [HttpGet()] //attribute says this method handles GET requests
        public List<Hotel> ListHotels()
        {
            return hotelDao.List(); //GET a list of all hotels
        }

        [HttpGet("{id}")] //get hotels based off their ID, added onto the route
        public ActionResult<Hotel> GetHotel(int id) //name for controller method = action, ActionResult is result of calling controller action
            //could return hotel or a status error code 
            //allows Hotel return type or something differernt 
        {
            Hotel hotel = hotelDao.Get(id); //go to DAO, get hotel

            if (hotel != null)
            {
                return hotel; //return hotel if we find one matching the given id
            }
            else
            { 
                return NotFound(); //return 404 if it doesnt exist
            }
        }
    }
}
