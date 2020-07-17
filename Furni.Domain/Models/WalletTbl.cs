using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class WalletTbl
    {
        public long WalletId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public long OrderId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string BalanceType { get; set; }
        public string Type { get; set; }
        public decimal Balance { get; set; }
        public string UserType { get; set; }
        public int? UserTypeId { get; set; }
        public bool? IsSettelled { get; set; }
    }
}
