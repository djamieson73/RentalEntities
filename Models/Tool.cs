using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Tool
{
    public int Id { get; set; }

    public int CatId { get; set; }

    public string ToolName { get; set; } = null!;

    public virtual Category Cat { get; set; } = null!;

    public virtual ICollection<ToolList> ToolLists { get; } = new List<ToolList>();
}
