using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DriverWithdrawal
    {
        public int Wid { get; set; }
        public int? DId { get; set; }
        public string Amount { get; set; }
        public DateTime? WithdrawalDate { get; set; }
        public string Status { get; set; }
        public int? Delete { get; set; }
    }
}
