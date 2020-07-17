using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CuisineTbl
    {
        public CuisineTbl()
        {
            CuisineLang = new HashSet<CuisineLang>();
            StoreAvailableCuisineTbl = new HashSet<StoreAvailableCuisineTbl>();
        }

        public int CuisineId { get; set; }
        public string CuisineName { get; set; }
        public bool? Status { get; set; }
        public bool IsDeleted { get; set; }
        public string Image { get; set; }
        public int ServiceTypeId { get; set; }

        public virtual ServiceTypetbl ServiceType { get; set; }
        public virtual ICollection<CuisineLang> CuisineLang { get; set; }
        public virtual ICollection<StoreAvailableCuisineTbl> StoreAvailableCuisineTbl { get; set; }
    }
}
