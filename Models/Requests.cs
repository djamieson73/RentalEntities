using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Models
{
    public class Requests2
    {
        public int ID { get; set; }
        public int ListId { get; set; }
        public string RenterId { get; set; } = null!;

        public string Message { get; set; } = null!;

        public DateTime DateIn { get; set; }

    }
}
