using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Paymenttbl
    {
        public int PaymentId { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public int OrderId { get; set; }

        public virtual Orders Order { get; set; }
    }
}
