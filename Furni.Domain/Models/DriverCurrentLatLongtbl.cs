using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DriverCurrentLatLongtbl
    {
        public int CurrentId { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public int? DriverId { get; set; }

        public virtual DriverReg Driver { get; set; }
    }
}
