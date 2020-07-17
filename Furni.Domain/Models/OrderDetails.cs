using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            OrderSubDetails = new HashSet<OrderSubDetails>();
        }

        public long OrderDetailId { get; set; }
        public string CartId { get; set; }
        public int StoreId { get; set; }
        public string ProductName { get; set; }
        public long ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public bool IsCustomizableItemAdd { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime DateCreated { get; set; }
        public int? OrderBaseDetailId { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? DiscountPer { get; set; }
        public decimal? DiscountedPrice { get; set; }

        public virtual ProductNew Product { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderSubDetails> OrderSubDetails { get; set; }
    }
}
