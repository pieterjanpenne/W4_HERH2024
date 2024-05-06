using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class FoodInfo
{
    public int FoodId { get; set; }

    public string? FoodName { get; set; }

    public string? FoodStatus { get; set; }

    public decimal? FoodPrice { get; set; }

    public string Details { get; set; } = null!;

    public virtual Ingredient Food { get; set; } = null!;

    public virtual KitchenStaff Food1 { get; set; } = null!;

    public virtual Payment FoodNavigation { get; set; } = null!;
}
