using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class KitchenStaff
{
    public int StaffId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Email { get; set; }

    public string? Pwd { get; set; }

    public string? Phone { get; set; }

    public string? Adress { get; set; }

    public decimal Salary { get; set; }

    public virtual FoodInfo? FoodInfo { get; set; }
}
