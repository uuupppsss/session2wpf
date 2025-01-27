﻿using System;
using System.Collections.Generic;

namespace api.Model;

public partial class EventType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
