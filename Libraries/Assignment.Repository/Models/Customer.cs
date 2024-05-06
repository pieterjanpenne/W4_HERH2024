using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Username { get; set; }

    public string Pwd { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? TcIdentityNum { get; set; }

    public string? PhoneNumber { get; set; }

    public string MailAdress { get; set; } = null!;

    public DateTime? BirthDate { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public virtual Reservation? Reservation { get; set; }
}
