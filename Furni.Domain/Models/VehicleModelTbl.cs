using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class VehicleModelTbl
    {
        public VehicleModelTbl()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int VModelId { get; set; }
        public int? VmId { get; set; }
        public string MName { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
