using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ItemAddOn
    {
        public int ItemAddOnId { get; set; }
        public int StoreId { get; set; }
        public long ProductId { get; set; }
        public string ItemAddOnName { get; set; }
        public decimal? ItemAddOnPrice { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ProductNew Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
