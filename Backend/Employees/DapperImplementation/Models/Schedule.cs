using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperImplementation.Models
{
    [Table("Schedules")]
    public class Schedule
    {
        [Key]
        public long Id { get; set; }
        public long MasterId { get; set; }
        public string WorkTime { get; set; }
    }
}
