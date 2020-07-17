using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ServiceTypetbl
    {
        public ServiceTypetbl()
        {
            BannerTbl = new HashSet<BannerTbl>();
            CuisineTbl = new HashSet<CuisineTbl>();
            Store = new HashSet<Store>();
        }

        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<BannerTbl> BannerTbl { get; set; }
        public virtual ICollection<CuisineTbl> CuisineTbl { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
