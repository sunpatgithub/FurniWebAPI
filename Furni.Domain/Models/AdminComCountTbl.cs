using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class AdminComCountTbl
    {
        public long AdminComId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? Amount { get; set; }
        public long? OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
