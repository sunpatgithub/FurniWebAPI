using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ItemOption
    {
        public int ItemOptionId { get; set; }
        public int StoreId { get; set; }
        public long ProductId { get; set; }
        public string ItemOptionName { get; set; }
        public decimal? ItemOptionPrice { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ProductNew Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
