using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class City
    {
        public City()
        {
            DriverAddress = new HashSet<DriverAddress>();
        }

        public int CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public string CityName { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }

        public virtual ICollection<DriverAddress> DriverAddress { get; set; }
    }
}
