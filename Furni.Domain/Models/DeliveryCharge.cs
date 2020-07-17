using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DeliveryCharge
    {
        public int DeliveryChargeId { get; set; }
        public int GeoLocationId { get; set; }
        public decimal OrderPrice { get; set; }
        public decimal AboveAmount { get; set; }
        public decimal BelowAmount { get; set; }
        public decimal? OrderAboveAmount { get; set; }
        public string DeliveryRadius { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}
