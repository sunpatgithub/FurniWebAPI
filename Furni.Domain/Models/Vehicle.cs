using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            VehicleDocument = new HashSet<VehicleDocument>();
        }

        public int VId { get; set; }
        public int DId { get; set; }
        public int? VtId { get; set; }
        public int? VmId { get; set; }
        public int? VModelId { get; set; }
        public int? Year { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleColor { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Delete { get; set; }
        public int Status { get; set; }

        public virtual DriverReg D { get; set; }
        public virtual VehicleModelTbl VModel { get; set; }
        public virtual ICollection<VehicleDocument> VehicleDocument { get; set; }
    }
}
