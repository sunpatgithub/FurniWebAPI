using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class GeoLocation
    {
        public GeoLocation()
        {
            RestrictedArea = new HashSet<RestrictedArea>();
            VehicleType = new HashSet<VehicleType>();
        }

        public int GeoLocationId { get; set; }
        public string LocationName { get; set; }
        public int CountryId { get; set; }
        public string LocationFor { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<RestrictedArea> RestrictedArea { get; set; }
        public virtual ICollection<VehicleType> VehicleType { get; set; }
    }
}
