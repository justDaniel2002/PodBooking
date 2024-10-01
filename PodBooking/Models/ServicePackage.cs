﻿using System;
using System.Collections.Generic;

namespace PodBooking.Models;

public partial class ServicePackage
{
    public int Id { get; set; }

    public string? PackageName { get; set; }

    public int? Duration { get; set; }

    public decimal? Price { get; set; }

    public string? Features { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
