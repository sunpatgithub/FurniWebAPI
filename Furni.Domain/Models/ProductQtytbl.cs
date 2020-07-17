using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ProductQtytbl
    {
        public long ProductQtyId { get; set; }
        public long ProductId { get; set; }
        public int Qty { get; set; }

        public virtual ProductNew Product { get; set; }
    }
}
