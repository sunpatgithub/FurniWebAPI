using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StoreOffer
    {
        public int Id { get; set; }
        public int? StoreId { get; set; }
        public string OfferApplyOn { get; set; }
        public string OfferType { get; set; }
        public decimal? OfferDiscount { get; set; }
        public decimal? TargetAmount { get; set; }
        public decimal? MaxAmount { get; set; }

        public virtual Store Store { get; set; }
    }
}
