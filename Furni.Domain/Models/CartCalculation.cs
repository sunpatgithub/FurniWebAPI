using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CartCalculation
    {
        public long RecordId { get; set; }
        public string CartId { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? DeliveryCharges { get; set; }
        public decimal? PackingCharges { get; set; }
        public decimal? Tax { get; set; }
        public decimal? PromotionalDiscount { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public string OfferApplyOn { get; set; }
        public string OfferType { get; set; }
        public decimal? OfferDiscount { get; set; }
        public decimal? TargetAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? OfferDiscountByStore { get; set; }
    }
}
