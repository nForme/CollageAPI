using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AuthHistory
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime DateTime { get; set; }

    public bool Status { get; set; }

    public virtual User User { get; set; } = null!;
}
