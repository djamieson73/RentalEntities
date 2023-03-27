using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? CatName { get; set; }

    public string? Alt { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Color { get; set; }

    public string? ColorBg { get; set; }

    public virtual ICollection<Tool> Tools { get; } = new List<Tool>();
}
