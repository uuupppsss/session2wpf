using System;
using System.Collections.Generic;

namespace api.Model;

public partial class Event
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? TypeId { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual ICollection<ResponciblePerson> ResponciblePeople { get; set; } = new List<ResponciblePerson>();

    public virtual EventType? Type { get; set; }
}
