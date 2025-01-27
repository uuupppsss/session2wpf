using System;
using System.Collections.Generic;

namespace api.Model;

public partial class Calendar
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? EventId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Event? Event { get; set; }
}
