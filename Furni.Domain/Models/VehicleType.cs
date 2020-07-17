using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class VehicleType
    {
        public int Vtid { get; set; }
        public string VehicleType1 { get; set; }
        public int? DeliveryChargeComplete { get; set; }
        public int? DeliveryChargeCancel { get; set; }
        public int? DeliveryRedius { get; set; }
        public int? DisplayOrder { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }
        public int? GeoLocationId { get; set; }

        public virtual GeoLocation GeoLocation { get; set; }
    }
}
