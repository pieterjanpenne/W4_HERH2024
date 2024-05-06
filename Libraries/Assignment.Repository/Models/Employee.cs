using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public decimal Salary { get; set; }

    public string Department { get; set; } = null!;

    public DateTime? Birthdate { get; set; }

    public string? Birthcity { get; set; }

    public string? Birthcountry { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Mail { get; set; }

    public virtual Chef? Chef { get; set; }

    public virtual Delivery? Delivery { get; set; }

    public virtual Waiter? Waiter { get; set; }
}
