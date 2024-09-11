using System;
using System.Collections.Generic;

namespace BookMyMovie.Models;

public partial class TheaterMovie
{
    public int TheaterMovieId { get; set; }

    public int? MovieId { get; set; }

    public int? TheaterId { get; set; }

    public DateTime? ShowOnTime { get; set; }

    public DateTime? ShowDownTime { get; set; }

    public string? ShowType { get; set; }

    public int? SeatCount { get; set; }

    public int? ScreenId { get; set; }

    public int? FirstClass { get; set; }

    public int? SecondClass { get; set; }

    public int? GoldClass { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public int? BookingId { get; set; }

    public virtual Booking? Booking { get; set; }

    public virtual Movie? Movie { get; set; }

    public virtual Screen? Screen { get; set; }

    public virtual Theater? Theater { get; set; }
}
