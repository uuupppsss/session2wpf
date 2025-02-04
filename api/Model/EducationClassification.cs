﻿using System;
using System.Collections.Generic;

namespace api.Model;

public partial class EducationClassification
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Education> Educations { get; set; } = new List<Education>();
}
