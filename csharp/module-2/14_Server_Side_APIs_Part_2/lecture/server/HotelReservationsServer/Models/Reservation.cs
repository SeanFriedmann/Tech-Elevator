using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    public class Reservation
    {
        public int Id { get; set; } //input data validation

        [Required(ErrorMessage = "The field 'HotelId' is required.")] //sends an error message if data wasnt inputted correctly
        public int HotelId { get; set; }

        [Required(ErrorMessage = "The field 'FullName' is required.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "The field 'CheckinDate' is required.")]
        public DateTime CheckinDate { get; set; }

        //[Required(ErrorMessage = "The field 'Nights' is required.")]
        [Range(1,14, ErrorMessage = "Between 1 and  14 night stay please.")] //makes sure the range is between 1 and 14
        public int Nights { get; set; }

        [Range(1,5)]
        public int Guests { get; set; }

        public Reservation()
        {
            //must have parameterless constructor to deserialize
        }

        public Reservation(int id, int hotelId, string fullName, DateTime checkinDate, int nights, int guests)
        {
            Id = id;
            HotelId = hotelId;
            FullName = fullName;
            CheckinDate = checkinDate;
            Nights = nights;
            Guests = guests;
        }
    }
}
