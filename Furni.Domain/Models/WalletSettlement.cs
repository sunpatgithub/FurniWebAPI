using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class WalletSettlement
    {
        public WalletSettlement()
        {
            AdminTransactionTransferDetail = new HashSet<AdminTransactionTransferDetail>();
        }

        public int SettledId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int UserTypeId { get; set; }
        public string BalanceType { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string UserType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Balance { get; set; }
        public bool? IsPaid { get; set; }

        public virtual ICollection<AdminTransactionTransferDetail> AdminTransactionTransferDetail { get; set; }
    }
}
