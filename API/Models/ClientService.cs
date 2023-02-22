using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ClientService
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int ServiceId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime Date { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}
