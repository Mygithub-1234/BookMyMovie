using System;
using System.Collections.Generic;

namespace BookMyMovie.Models;

public partial class Theater
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<TheaterMovie> TheaterMovies { get; set; } = new List<TheaterMovie>();
}
