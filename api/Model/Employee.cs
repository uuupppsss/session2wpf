using System;
using System.Collections.Generic;

namespace api.Model;

public partial class Employee
{
    public int Id { get; set; }

    public string Initials { get; set; } = null!;

    public DateOnly? Birthday { get; set; }

    public string Phone { get; set; } = null!;

    public string Office { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int SubdivisionId { get; set; }

    public string? Ect { get; set; }

    public int? SupervisorId { get; set; }

    public int? HelperId { get; set; }

    public int JobTitleId { get; set; }

    public string? MobilePhone { get; set; }

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual Employee? Helper { get; set; }

    public virtual ICollection<Employee> InverseHelper { get; set; } = new List<Employee>();

    public virtual ICollection<Employee> InverseSupervisor { get; set; } = new List<Employee>();

    public virtual JobTitle JobTitle { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

    public virtual ICollection<ResponciblePerson> ResponciblePeople { get; set; } = new List<ResponciblePerson>();

    public virtual Subdivision Subdivision { get; set; } = null!;

    public virtual Employee? Supervisor { get; set; }
}
