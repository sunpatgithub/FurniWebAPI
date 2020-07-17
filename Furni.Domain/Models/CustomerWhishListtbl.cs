using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CustomerWhishListtbl
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
