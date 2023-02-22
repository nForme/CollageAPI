using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Client
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public DateTime Birthday { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;

    public int GenderId { get; set; }

    public virtual Gender Gender { get; set; } = null!;
}
