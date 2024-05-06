using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Transaction
{
    public int TransId { get; set; }

    public string? TransReportNum { get; set; }

    public DateTime? TransDate { get; set; }

    public DateTime TransReportDate { get; set; }

    public virtual Delivery Trans { get; set; } = null!;

    public virtual Payment TransNavigation { get; set; } = null!;
}
