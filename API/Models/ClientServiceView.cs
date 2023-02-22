using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ClientServiceView
{
    public int Id { get; set; }

    public string? ClientInfo { get; set; }

    public string? EmployeeInfo { get; set; }

    public string Service { get; set; } = null!;

    public decimal Cost { get; set; }

    public DateTime Date { get; set; }
}
