using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class RestaurantStatus
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public DateTime? StatusDate { get; set; }

    public virtual Reservation? Reservation { get; set; }
}
