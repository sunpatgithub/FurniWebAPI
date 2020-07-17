using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StoreAvailableCuisineTbl
    {
        public long Id { get; set; }
        public int StoreId { get; set; }
        public int CuisineId { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual CuisineTbl Cuisine { get; set; }
        public virtual Store Store { get; set; }
    }
}
