using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Country
    {
        public Country()
        {
            DriverAddress = new HashSet<DriverAddress>();
            GeoLocation = new HashSet<GeoLocation>();
            StoreAddress = new HashSet<StoreAddress>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }

        public virtual ICollection<DriverAddress> DriverAddress { get; set; }
        public virtual ICollection<GeoLocation> GeoLocation { get; set; }
        public virtual ICollection<StoreAddress> StoreAddress { get; set; }
    }
}
