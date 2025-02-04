using System;
using System.Collections.Generic;

namespace api.Model;

public partial class AbsenceReason
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<EmployeesAbsenceCalendar> EmployeesAbsenceCalendars { get; set; } = new List<EmployeesAbsenceCalendar>();
}
