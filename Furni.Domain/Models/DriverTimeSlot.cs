using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DriverTimeSlot
    {
        public int DriverTimeId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int DriverId { get; set; }
        public string Slot { get; set; }
        public int WeekId { get; set; }

        public virtual DriverReg Driver { get; set; }
        public virtual Weektbl Week { get; set; }
    }
}
