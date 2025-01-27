using System;
using System.Collections.Generic;

namespace api.Model;

public partial class Subdivision
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? SupervisorId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
