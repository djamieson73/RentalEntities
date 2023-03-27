using AutoMapper.Configuration.Annotations;
using System;
using System.Collections.Generic;

namespace Entities.Models;

public class City
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    [Ignore]
    public ICollection<PointOfInterest> PointOfInterests { get; } = new List<PointOfInterest>();
}
