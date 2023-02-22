using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ServiceCategory
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}
