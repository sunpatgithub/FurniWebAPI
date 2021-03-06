﻿using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DriverAddress
    {
        public int DAId { get; set; }
        public int? DId { get; set; }
        public string Location { get; set; }
        public string AddressLine { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string ZipCode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Delete { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual DriverReg D { get; set; }
        public virtual State State { get; set; }
    }
}
