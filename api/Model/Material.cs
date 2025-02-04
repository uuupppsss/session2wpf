using System;
using System.Collections.Generic;

namespace api.Model;

public partial class Material
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly DateAccept { get; set; }

    public DateOnly? DateChange { get; set; }

    public string? Status { get; set; }

    public string Type { get; set; } = null!;

    public string Area { get; set; } = null!;

    public int AuthorId { get; set; }

    public virtual Employee Author { get; set; } = null!;

    public virtual ICollection<EducationMaterial> EducationMaterials { get; set; } = new List<EducationMaterial>();
}
