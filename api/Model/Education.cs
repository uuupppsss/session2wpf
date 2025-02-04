using System;
using System.Collections.Generic;

namespace api.Model;

public partial class Education
{
    public int Id { get; set; }

    public DateOnly DateStart { get; set; }

    public DateOnly DateEnd { get; set; }

    public int ClassificationId { get; set; }

    public string? Description { get; set; }

    public virtual EducationClassification Classification { get; set; } = null!;

    public virtual ICollection<EducationEmployee> EducationEmployees { get; set; } = new List<EducationEmployee>();

    public virtual ICollection<EducationMaterial> EducationMaterials { get; set; } = new List<EducationMaterial>();
}
