using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? IdInvoice { get; set; }

    public string? Number { get; set; }

    public string? Type { get; set; }

    public string? Method { get; set; }

    public DateTime PaymentDate { get; set; }

    public decimal PaymentAmount { get; set; }

    public virtual Delivery? Delivery { get; set; }

    public virtual FoodInfo? FoodInfo { get; set; }

    public virtual Menu PaymentNavigation { get; set; } = null!;

    public virtual Transaction? Transaction { get; set; }
}
