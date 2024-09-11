using System;
using System.Collections.Generic;

namespace BookMyMovie.Models;

public partial class Admin
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public bool? IsActive { get; set; }
}
