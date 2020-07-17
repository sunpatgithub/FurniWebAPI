using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CodtransferDetails
    {
        public int PaymentId { get; set; }
        public int DriverId { get; set; }
        public DateTime TransferredDate { get; set; }
        public decimal TransferredAmount { get; set; }
        public string TransactionDetails { get; set; }
        public string Comments { get; set; }
        public string Attachment { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? PaymentMode { get; set; }

        public virtual DriverReg Driver { get; set; }
    }
}
