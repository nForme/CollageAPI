﻿using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? PhotoPath { get; set; }

    public virtual ICollection<ServiceCategory> ServiceCategories { get; } = new List<ServiceCategory>();
}
