using System;
using System.Collections.Generic;

namespace api.Model;

public partial class Material
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateOnly? DateAccept { get; set; }

    public DateOnly? DateChange { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public string? Area { get; set; }

    public int? AuthorId { get; set; }

    public virtual Employee? Author { get; set; }
}
