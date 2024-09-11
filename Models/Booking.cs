using System;
using System.Collections.Generic;

namespace BookMyMovie.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? NumberOfTickets { get; set; }

    public int? TotalPrice { get; set; }

    public DateTime? BookingDate { get; set; }

    public int? BookingStatus { get; set; }

    public int? PaymentStatus { get; set; }

    public int? TheaterMovieId { get; set; }

    public int? CustId { get; set; }

    public virtual Customer? Cust { get; set; }

    public virtual ICollection<TheaterMovie> TheaterMovies { get; set; } = new List<TheaterMovie>();
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