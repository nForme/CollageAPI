using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Service
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Cost { get; set; }

    public string? Description { get; set; }

    public bool IsActual { get; set; }

    public virtual ICollection<ClientService> ClientServices { get; } = new List<ClientService>();

    public virtual ICollection<ServiceCategory> ServiceCategories { get; } = new List<ServiceCategory>();
}
