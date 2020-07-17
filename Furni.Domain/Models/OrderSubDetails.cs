using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class OrderSubDetails
    {
        public long OrderSubDetailsId { get; set; }
        public long OrderDetailId { get; set; }
        public string ItemType { get; set; }
        public int ItemTypeId { get; set; }
        public string ItemName { get; set; }
        public decimal? ItemPrice { get; set; }

        public virtual OrderDetails OrderDetail { get; set; }
    }
}
