using HotelReservations.DAO;
using HotelReservations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelReservations.Controllers
{
    [Route("reservations")] //localhost:5001/reservations
    [ApiController] //api controller specificiation
    public class ReservationsController : ControllerBase //
    {
        private static IReservationDao reservationDao;
        private static IHotelDao hotelDao;
        public ReservationsController()
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
            if (reservationDao == null)
            {
                reservationDao = new ReservationMemoryDao();
            }
        }
        //GetReservations
        [HttpGet()] //GET reqs to reservations
        public List<Reservation> ListReservations() //return type of a list of reservations named ListReservations
        {
            return reservationDao.List(); //returns the list of rservations coming from ReservationMemoryDao
        }


        //GetReservationByID
        [HttpGet("{id}")]
        public ActionResult<Reservation> GetReservationById(int id) //parameter needs to match what you put in your route
        {
            Reservation reservation = reservationDao.Get(id);

            if (reservation != null)
            {
                return reservation;
            }
            else
            {
                return NotFound();
            }
        }
        //GetReservationsByHotelId
        [HttpGet("/hotels/{hotelId}/reservations")] //even tho the expected row is /hotels/:id/reservations
        //starting with a "/" will change where you want to start from what your controller specifies 
        public ActionResult<List<Reservation>> GetReservationByHotelId(int hotelId) //return either not found or a list of thingie, match parameters
        {
            Hotel hotel = hotelDao.Get(hotelId); //find wanted hotel first
            if (hotel == null)
            {
                return NotFound();
            }
            return reservationDao.FindByHotel(hotelId); //use the findbyhotel method from resmemory and specify the inputted hotelid
        }


        //AddReservation
       [HttpPost()] //post is for creating
       public ActionResult<Reservation> AddReservation(Reservation newReservation) //either give the result back or give error 404
        {
            Reservation addedReservation = reservationDao.Create(newReservation); //try to add new reservation to wherever our data comes from
            if (addedReservation != null)
            {
                //return res and 201 created status code
                return Created($"/reservations/{addedReservation.Id}", addedReservation); //route to newly created thing and object name
            }
            else
            {
                return Problem("Cannot create this reservation");
            }
        }
        

        //UpdateReservation
        [HttpPut("{id}")] //show you want to be in reservations/:id
        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservation)
        {
            Reservation existingReservation = reservationDao.Get(id); //make sure res exists before you try to update it

           
            if (existingReservation == null)
            {
                return NotFound();
            }
            Reservation updatedRes = reservationDao.Update(existingReservation.Id, reservation);
            return updatedRes;
        }

        //DeleteReservation
        [HttpDelete("{id}")]
        public ActionResult DeleteReservation(int id) //no type action result
        {
            Reservation existingReservation = reservationDao.Get(id); //make sure it exists before you delete it

            if (existingReservation == null)
            {
                return NotFound();
            }
            bool result = reservationDao.Delete(id);
            if (result) //if thing was deleted
            {
                return NoContent(); //the object was deleted, code 204
            }
            else
            {
                return StatusCode(500); //500, something went wrong :)
            }
            
        }



    }
}
