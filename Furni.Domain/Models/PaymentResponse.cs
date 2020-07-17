using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class PaymentResponse
    {
        public int PaymentResponseId { get; set; }
        public int? OrderId { get; set; }
        public int? CustomerId { get; set; }
        public string Status { get; set; }
        public string Avs { get; set; }
        public string Code { get; set; }
        public string CaValid { get; set; }
        public string CardCode { get; set; }
        public string CardLast4 { get; set; }
        public string Cvv { get; set; }
        public string TranRef { get; set; }
        public string Trace { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Orders Order { get; set; }
    }
}
