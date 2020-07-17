using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StatusLogtbl
    {
        public long StatusLogId { get; set; }
        public long? OrderId { get; set; }
        public DateTime? DateTime { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
