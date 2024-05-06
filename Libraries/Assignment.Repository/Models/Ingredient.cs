using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Ingredient
{
    public int IngredientId { get; set; }

    public string? IngredientName { get; set; }

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public decimal Price { get; set; }

    public string? Detail { get; set; }

    public virtual Delivery? Delivery { get; set; }

    public virtual FoodInfo? FoodInfo { get; set; }

    public virtual Menu IngredientNavigation { get; set; } = null!;
}
