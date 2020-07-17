using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StoreBankDetails
    {
        public int SAccId { get; set; }
        public int? SId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BankCode { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Delete { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }

        public virtual Store S { get; set; }
    }
}
