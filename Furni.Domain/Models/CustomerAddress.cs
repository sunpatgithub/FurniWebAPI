using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CustomerAddress
    {
        public int AddressId { get; set; }
        public int? CustId { get; set; }
        public string Location { get; set; }
        public string AddressLine { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Delete { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
