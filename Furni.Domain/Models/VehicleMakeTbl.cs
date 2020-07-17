using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class VehicleMakeTbl
    {
        public int VmId { get; set; }
        public string Name { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }
    }
}
