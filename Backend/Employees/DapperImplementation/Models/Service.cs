using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperImplementation.Models
{
    [Table("Services")]
    public class Service
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public long SpecificationId { get; set; }
    }
}
