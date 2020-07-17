using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class RestrictedArea
    {
        public int RestrictedAreaId { get; set; }
        public int GeoLocationId { get; set; }
        public string RestrictedAreaName { get; set; }
        public string RestrictedAreaType { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

        public virtual GeoLocation GeoLocation { get; set; }
    }
}
