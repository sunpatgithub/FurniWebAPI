using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ManageDocument
    {
        public ManageDocument()
        {
            DriverDocument = new HashSet<DriverDocument>();
            ManageDocLang = new HashSet<ManageDocLang>();
            StoreDocument = new HashSet<StoreDocument>();
            VehicleDocument = new HashSet<VehicleDocument>();
        }

        public int DocMgmtId { get; set; }
        public int DocForId { get; set; }
        public int CountryId { get; set; }
        public bool ExpireOnDate { get; set; }
        public string DocumentName { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<DriverDocument> DriverDocument { get; set; }
        public virtual ICollection<ManageDocLang> ManageDocLang { get; set; }
        public virtual ICollection<StoreDocument> StoreDocument { get; set; }
        public virtual ICollection<VehicleDocument> VehicleDocument { get; set; }
    }
}
