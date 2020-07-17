using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class OrderBaseDetails
    {
        public int OrderBaseDetailId { get; set; }
        public string CartId { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public string PromoCode { get; set; }
        public string CustomerAddress { get; set; }
        public string DeliveryPreference { get; set; }
        public DateTime? PreferableDateTime { get; set; }
        public string CustomerNotes { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DeliveryCharges { get; set; }
        public decimal PackingCharges { get; set; }
        public decimal Tax { get; set; }
        public decimal PromotionalDiscount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public string OfferApplyOn { get; set; }
        public string OfferType { get; set; }
        public decimal? OfferDiscount { get; set; }
        public decimal? TargetAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? OfferDiscountByStore { get; set; }
        public string DeliverToVehicleDetail { get; set; }
        public int? CashHandlingChargeForDriver { get; set; }
    }
}
