using System;
using System.Collections.Generic;

namespace api.Model;

public partial class EducationMaterial
{
    public int Id { get; set; }

    public int MaterialId { get; set; }

    public int EducationId { get; set; }

    public virtual Education Education { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;
}
