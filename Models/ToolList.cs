using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class ToolList
{
    public int Id { get; set; }

    public int? ToolId { get; set; }

    public string? UserId { get; set; }

    public DateTime? DateIn { get; set; }

    public int? Price { get; set; }

    public string? Description { get; set; }

    public string? ImageDir { get; set; }

    public string? ImageFilename { get; set; }

    public virtual Tool? Tool { get; set; }
}
