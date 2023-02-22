using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string Post { get; set; } = null!;

    public byte[]? PhotoPath { get; set; }

    public virtual ICollection<ClientService> ClientServices { get; } = new List<ClientService>();
}
