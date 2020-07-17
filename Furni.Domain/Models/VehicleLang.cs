using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class VehicleLang
    {
        public int VehicleLangId { get; set; }
        public int Vtid { get; set; }
        public string VehicleType { get; set; }
        public int? LangId { get; set; }
    }
}
