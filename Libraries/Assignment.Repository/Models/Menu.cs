using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string? Number { get; set; }

    public string? Details { get; set; }

    public decimal Price { get; set; }

    public virtual Ingredient? Ingredient { get; set; }

    public virtual Payment? Payment { get; set; }

    public virtual Reservation? Reservation { get; set; }
}
