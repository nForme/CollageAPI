using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; } = new List<Client>();
}
