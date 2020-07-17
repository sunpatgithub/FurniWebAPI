using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CustomizeOrdertbl
    {
        public int CustumizeId { get; set; }
        public int OrderId { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public int ProductId { get; set; }
    }
}
