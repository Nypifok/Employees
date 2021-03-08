using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperImplementation.Models
{
    [Table("Users")]
   public class User
    {
        public long Id { get; set; }
    }
}
