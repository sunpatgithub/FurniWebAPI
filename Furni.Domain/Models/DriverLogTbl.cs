using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DriverLogTbl
    {
        public int DriverLogId { get; set; }
        public int? DId { get; set; }
        public DateTime? OnlineTime { get; set; }
        public DateTime? OfflineTime { get; set; }
        public long? OrderId { get; set; }
    }
}
