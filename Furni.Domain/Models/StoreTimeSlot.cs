using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StoreTimeSlot
    {
        public int StoreTimeId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int StoreId { get; set; }
        public string Slot { get; set; }
        public int WeekId { get; set; }

        public virtual Store Store { get; set; }
        public virtual Weektbl Week { get; set; }
    }
}
