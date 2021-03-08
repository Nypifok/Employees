using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperImplementation.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public long Id { get; set; }
        public long MasterId { get; set; }
        public long UserId { get; set; }
        public long ServiceId { get; set; }
        public string Description { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public bool Status { get; set; }
        public string Comment { get; set; }
        public string Images { get; set; }

    }
}
