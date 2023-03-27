using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PointOfInterest
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int CityId { get; set; }

    public virtual City City { get; set; } = null!;
}
