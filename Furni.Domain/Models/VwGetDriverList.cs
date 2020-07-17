using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class VwGetDriverList
    {
        public double StoreLatitude { get; set; }
        public double StoreLongtitude { get; set; }
        public double CustLatitude { get; set; }
        public double CustLongtitude { get; set; }
        public double DriverLatitude { get; set; }
        public double DriverLongtitude { get; set; }
        public int? VehicleRedius { get; set; }
        public int DriverId { get; set; }
        public double? Distance { get; set; }
        public string DeviceToken { get; set; }
        public string DeviceType { get; set; }
    }
}
