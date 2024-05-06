using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Delivery
{
    public int DeliveryId { get; set; }

    public short? DeliveryNumber { get; set; }

    public DateTime DeliveryDate { get; set; }

    public string? DeliveryStatus { get; set; }

    public virtual Employee Delivery1 { get; set; } = null!;

    public virtual Ingredient Delivery2 { get; set; } = null!;

    public virtual RestaurantManager Delivery3 { get; set; } = null!;

    public virtual Payment Delivery4 { get; set; } = null!;

    public virtual Crew DeliveryNavigation { get; set; } = null!;

    public virtual Transaction? Transaction { get; set; }
}
