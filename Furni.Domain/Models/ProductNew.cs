using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ProductNew
    {
        public ProductNew()
        {
            ItemAddOn = new HashSet<ItemAddOn>();
            ItemOption = new HashSet<ItemOption>();
            OrderDetails = new HashSet<OrderDetails>();
            ProductQtytbl = new HashSet<ProductQtytbl>();
            StoreOrder = new HashSet<StoreOrder>();
        }

        public long ProductId { get; set; }
        public int CategoryId { get; set; }
        public int StoreId { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal? ProductOfferAmt { get; set; }
        public byte ProductOrderDisplay { get; set; }
        public string ProductImage { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemTagId { get; set; }
        public bool? ProductStock { get; set; }
        public bool? ProductRecommended { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? EstimationItemPreparingTime { get; set; }

        public virtual CategoryTbl Category { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<ItemAddOn> ItemAddOn { get; set; }
        public virtual ICollection<ItemOption> ItemOption { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<ProductQtytbl> ProductQtytbl { get; set; }
        public virtual ICollection<StoreOrder> StoreOrder { get; set; }
    }
}
