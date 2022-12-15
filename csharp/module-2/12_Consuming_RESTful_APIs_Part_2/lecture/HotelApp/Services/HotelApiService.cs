using HotelReservationsClient.Models;
using HotelReservationsClient.Utility;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HotelReservationsClient.Services
{
    public class HotelApiService
    {
        protected static RestClient client = null;

        public HotelApiService(string apiUrl)
        {
            if (client == null)
            {
                client = new RestClient(apiUrl);
            }
        }

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest("hotels");
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            CheckForError(response, "Get hotels");
            return response.Data;
        }

        public List<Reservation> GetReservations(int hotelId = 0) //default value for the parameter
        {
            string url; //create string named url
            if (hotelId != 0)
            {
                url = $"hotels/{hotelId}/reservations"; //get reservations for the specific hotel mentioned
            }
            else
            { 
                url = "reservations"; //if id isnt set get all reservations
            }

            RestRequest request = new RestRequest(url);
            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request); //GET request lines

            CheckForError(response, $"Get reservations for hotel {hotelId}"); //error handling
            return response.Data; //returns the list 
        }

        public Reservation GetReservation(int reservationId)
        {
            RestRequest request = new RestRequest($"reservations/{reservationId}");
            IRestResponse<Reservation> response = client.Get<Reservation>(request);

            CheckForError(response, $"Get reservation {reservationId}");
            return response.Data;
        }

        public Reservation AddReservation(Reservation newReservation) //gives us a new reservation with data already filled out
        {
            RestRequest request = new RestRequest("reservations");
            request.AddJsonBody(newReservation); //change request to JSON data
            IRestResponse<Reservation> response = client.Post<Reservation>(request); //create response

            CheckForError(response, $"Add reserveration for {newReservation.HotelId}"); //handle errors
            return response.Data; //return data
        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            RestRequest request = new RestRequest($"reservations/{reservationToUpdate.Id}");
            request.AddJsonBody(reservationToUpdate); //change request to JSON data for data being updated
            IRestResponse<Reservation> response = client.Put<Reservation>(request); //will override whole object on the server

            CheckForError(response, $"Update reservation {reservationToUpdate.HotelId}"); //handle errors
            return response.Data;
        }

        public bool DeleteReservation(int reservationId)
        {
            
            RestRequest request = new RestRequest($"reseverations/{reservationId}");
            IRestResponse response = client.Delete(request); //ensure you want to delete this info
            //request.AddJsonBody(reservationId);
            CheckForError(response, $"Delete reservation {reservationId}");
            return true; //successful delete if there are no errors
        }

        /// <summary>
        /// Checks RestSharp response for errors. If error, writes a log message and throws an exception 
        /// if the call was not successful. If no error, just returns to caller.
        /// </summary>
        /// <param name="response">Response returned from a RestSharp method call.</param>
        /// <param name="action">Description of the action the application was taking. Written to the log file for context.</param>
        private void CheckForError(IRestResponse response, string action)
        {
            if (!response.IsSuccessful)
            {
                // TODO: Write a log message for future reference

                throw new HttpRequestException($"There was an error in the call to the server");
            }

        }
    }
}
