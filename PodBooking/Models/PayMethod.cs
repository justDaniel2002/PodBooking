﻿using System;
using System.Collections.Generic;

namespace PodBooking.Models;

public partial class PayMethod
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<FoodOrder> FoodOrders { get; set; } = new List<FoodOrder>();
}
