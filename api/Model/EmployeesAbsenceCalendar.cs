using System;
using System.Collections.Generic;

namespace api.Model;

public partial class EmployeesAbsenceCalendar
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public int ReasonId { get; set; }

    public int InsteadEmployeeId { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Employee InsteadEmployee { get; set; } = null!;

    public virtual AbsenceReason Reason { get; set; } = null!;
}
