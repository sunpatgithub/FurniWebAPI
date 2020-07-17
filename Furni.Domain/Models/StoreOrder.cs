using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StoreOrder
    {
        public int StoreOrderId { get; set; }
        public long ProductId { get; set; }
        public int StoreId { get; set; }
        public int OrderId { get; set; }
        public int? Qty { get; set; }
        public decimal? FinalPrice { get; set; }

        public virtual Orders Order { get; set; }
        public virtual ProductNew Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
