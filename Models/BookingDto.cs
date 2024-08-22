namespace BookMyMovie.Models
{
    public class BookingDto
    {
        public int UserId { get; set; }

        public int NumberOfTickets { get; set; }

        public int TotalPrice { get; set; }

        public DateTime BookingDate { get; set; }
        //public BookingStatus BookingStatus { get; set; }
        //public PaymentStatus PaymentStatus { get; set; }

        //public int Theater_MovieId { get; set; }
    }
}
