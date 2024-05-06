using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public DateTime? ReservDate { get; set; }

    public DateTime ReservTime { get; set; }

    public int NoOfGuest { get; set; }

    public string? ReservTableNo { get; set; }

    public virtual Menu Reservation1 { get; set; } = null!;

    public virtual RestaurantStatus Reservation2 { get; set; } = null!;

    public virtual Customer ReservationNavigation { get; set; } = null!;
}
