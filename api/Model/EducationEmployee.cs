using System;
using System.Collections.Generic;

namespace api.Model;

public partial class EducationEmployee
{
    public int Id { get; set; }

    public int EducationId { get; set; }

    public int EmployeeId { get; set; }

    public virtual Education Education { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
