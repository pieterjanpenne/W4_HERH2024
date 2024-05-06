using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Waiter
{
    public int WaiterId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Username { get; set; } = null!;

    public string Pwd { get; set; } = null!;

    public int? TcIdentityNum { get; set; }

    public DateTime? BirthDate { get; set; }

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public decimal? Salary { get; set; }

    public virtual Employee Waiter1 { get; set; } = null!;

    public virtual Crew WaiterNavigation { get; set; } = null!;
}
