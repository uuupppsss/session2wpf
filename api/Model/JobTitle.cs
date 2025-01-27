using System;
using System.Collections.Generic;

namespace api.Model;

public partial class JobTitle
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
