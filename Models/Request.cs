using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Request
{
    public int Id { get; set; }

    public int? ListId { get; set; }

    public string? RenterId { get; set; }

    public string? Message { get; set; }

    public DateTime? RequestDate { get; set; }

    public DateTime? DateIn { get; set; }
}
