using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Weektbl
    {
        public Weektbl()
        {
            DriverTimeSlot = new HashSet<DriverTimeSlot>();
            StoreTimeSlot = new HashSet<StoreTimeSlot>();
        }

        public int WeekId { get; set; }
        public string WeekName { get; set; }

        public virtual ICollection<DriverTimeSlot> DriverTimeSlot { get; set; }
        public virtual ICollection<StoreTimeSlot> StoreTimeSlot { get; set; }
    }
}
