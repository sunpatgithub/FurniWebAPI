using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Carts
    {
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int StoreId { get; set; }
        public long ProductId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
        public bool IsCustomizableItemAdd { get; set; }
        public DateTime DateCreated { get; set; }
        public string PromoCode { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? DiscountPer { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public string ItemOptionId { get; set; }
        public string ItemAddOnId { get; set; }
    }
}
