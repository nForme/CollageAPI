using System;
using System.Collections.Generic;

namespace API.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? Lastenter { get; set; }

    public int RoleId { get; set; }

    public virtual ICollection<AuthHistory> AuthHistories { get; } = new List<AuthHistory>();

    public virtual Role Role { get; set; } = null!;
}
