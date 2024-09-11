using System;
using System.Collections.Generic;

namespace BookMyMovie.Models;

public partial class Screen
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? MaxSeat { get; set; }

    public string? Class { get; set; }

    public virtual ICollection<TheaterMovie> TheaterMovies { get; set; } = new List<TheaterMovie>();
}
