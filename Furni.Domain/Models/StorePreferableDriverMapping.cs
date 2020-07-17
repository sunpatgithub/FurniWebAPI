using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StorePreferableDriverMapping
    {
        public int PreferableId { get; set; }
        public int StoreId { get; set; }
        public int DriverId { get; set; }
        public int DeliveryCompanyId { get; set; }

        public virtual DriverReg Driver { get; set; }
        public virtual Store Store { get; set; }
    }
}
