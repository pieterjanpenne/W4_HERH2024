using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class RestaurantManager
{
    public int ManagerId { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? TcIdentityNum { get; set; }

    public string Pwd { get; set; } = null!;

    public DateTime? BirthDate { get; set; }

    public string? PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public string? HomeAdress { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public virtual Delivery? Delivery { get; set; }
}
