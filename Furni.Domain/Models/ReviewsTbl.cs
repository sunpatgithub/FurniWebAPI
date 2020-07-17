using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ReviewsTbl
    {
        public long ReviewId { get; set; }
        public int OrderId { get; set; }
        public int FromUserTypeId { get; set; }
        public int ToUserTypeId { get; set; }
        public decimal Rate { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
