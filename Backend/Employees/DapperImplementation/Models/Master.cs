using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperImplementation.Models
{
    [Table("Masters")]
    public class Master
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public long LocationId { get; set; }
        public long SpecificatonId { get; set; }
    }
}
