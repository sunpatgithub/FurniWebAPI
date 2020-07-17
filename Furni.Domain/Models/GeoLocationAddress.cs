using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class GeoLocationAddress
    {
        public int Id { get; set; }
        public int GeoFenceId { get; set; }
        public double? Latitude { get; set; }
        public double? Longtitude { get; set; }
    }
}
