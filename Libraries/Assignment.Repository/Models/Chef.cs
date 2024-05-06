using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Chef
{
    public int ChefId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Username { get; set; }

    public string Email { get; set; } = null!;

    public string? Pwd { get; set; }

    public DateTime BirthDate { get; set; }

    public string? Position { get; set; }

    public decimal? Salary { get; set; }

    public string? BirthCountry { get; set; }

    public virtual Employee ChefNavigation { get; set; } = null!;
}
