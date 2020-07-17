using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class PayToStoreFromDriver
    {
        public int PayId { get; set; }
        public string OrderId { get; set; }
        public int DriverId { get; set; }
        public int StoreId { get; set; }
        public DateTime TransferredDateFromDrive { get; set; }
        public DateTime? ReceivedDateToStore { get; set; }
        public bool PayStatus { get; set; }
        public decimal TotalAmt { get; set; }

        public virtual DriverReg Driver { get; set; }
        public virtual Store Store { get; set; }
    }
}
