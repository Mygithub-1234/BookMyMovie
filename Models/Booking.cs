using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookMyMovie.Models
{
    public class Booking
    {
        [Key]
        
        public int BookingId { get; set; }
        public int UserId { get; set; }

        public int NumberOfTickets { get; set; }

        public int TotalPrice { get; set; }

        public DateTime BookingDate { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public int Theater_MovieId { get; set; }


    }
    public enum BookingStatus
    {
        Pending = 3,
        Confirmed = 2,
        Cancelled = 0,
        Completed = 1
    }

    public enum PaymentStatus
    {
        Pending = 0,
        Success = 1,
        Failed = -1
    }
}
