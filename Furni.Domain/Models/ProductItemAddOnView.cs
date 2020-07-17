using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ProductItemAddOnView
    {
        public int ItemAddOnId { get; set; }
        public string ItemAddOnName { get; set; }
        public string ItemAddOnPrice { get; set; }
    }
}
