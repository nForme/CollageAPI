using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? PhotoPath { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
