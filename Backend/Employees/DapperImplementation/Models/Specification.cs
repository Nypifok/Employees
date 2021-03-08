using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperImplementation.Models
{
    [Table("Specifications")]
    public class Specification
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
