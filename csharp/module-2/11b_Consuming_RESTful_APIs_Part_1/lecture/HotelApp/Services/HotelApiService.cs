using HotelApp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HotelApp.Services
{
    public class HotelApiService
    {
        protected static RestClient client = null; //set to null to create a new variable of RestClient but pull the info from somewhere else 

        public HotelApiService(string apiUrl) //API service constructor
        {
            if (client == null)
            {
                client = new RestClient(apiUrl); //build a client, is set to base url if it wasnt already assigned
            }
        }

        public List<Hotel> GetHotels() //should be at localhost:3000/hotels to display hotels
        {
            //build a new request object
            RestRequest request = new RestRequest("hotels"); //make a request to /hotels
                                                             //send the request to the api
            IRestResponse<List<Hotel>> restResponse = client.Get<List<Hotel>>(request); //need to specify the data type on both sides for it to function
            if (!restResponse.IsSuccessful) //check to see if response was not a success
            {
                throw new HttpRequestException("Something went wrong communicating with the server");
            } 
            
            return(restResponse.Data); //display the data we just got to the program
        }

        public List<Review> GetReviews()
        {
            RestRequest request = new RestRequest("reviews");
            IRestResponse<List<Review>> restResponse = client.Get<List<Review>>(request);
            if (!restResponse.IsSuccessful)
            {
                throw new HttpRequestException("Something went wrong communicating with the server");
            }
            return (restResponse.Data);
        }

        public Hotel GetHotel(int hotelId)
        {
            RestRequest request = new RestRequest($"hotels/{hotelId}");
            IRestResponse<Hotel> response = client.Get<Hotel>(request);
            if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Something went wrong");
            }

            return response.Data;
        }

        public List<Review> GetHotelReviews(int hotelId)
        {
            RestRequest request = new RestRequest($"reviews?hotelId={hotelId}"); //that was a toughy
            IRestResponse<List<Review>> response = client.Get<List<Review>>(request);
           if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Something went wrong");
            }
            
            return response.Data;
        }

        public List<Hotel> GetHotelsWithRating(int starRating)
        {
            RestRequest request = new RestRequest($"hotels?stars={starRating}");
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);
            if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Something went wrong :(");
            }
            return response.Data;
        }
        
        public City GetPublicAPIQuery()
        {
            throw new NotImplementedException();
        }
    }
}
