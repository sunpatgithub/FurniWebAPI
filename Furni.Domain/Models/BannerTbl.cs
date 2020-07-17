using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class BannerTbl
    {
        public int BannerId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
        public bool? Status { get; set; }
        public bool IsDelete { get; set; }
        public int ServiceTypeId { get; set; }

        public virtual ServiceTypetbl ServiceType { get; set; }
    }
}
