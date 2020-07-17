using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class AdminTransactionTransferDetail
    {
        public long TransactionId { get; set; }
        public int? SettledId { get; set; }
        public string TransactionDetails { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Comment { get; set; }
        public double? TransactionAmount { get; set; }
        public string PaymentMode { get; set; }
        public string Attachment { get; set; }
        public bool? IsCancel { get; set; }

        public virtual WalletSettlement Settled { get; set; }
    }
}
