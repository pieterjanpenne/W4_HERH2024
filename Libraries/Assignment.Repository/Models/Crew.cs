using System;
using System.Collections.Generic;

namespace Assignment.Repository.Models;

public partial class Crew
{
    public int CrewId { get; set; }

    public string? CrewName { get; set; }

    public int CrewNumber { get; set; }

    public decimal? CrewTotalSalary { get; set; }

    public int CrewUserId { get; set; }

    public virtual Delivery? Delivery { get; set; }

    public virtual Waiter? Waiter { get; set; }
}
