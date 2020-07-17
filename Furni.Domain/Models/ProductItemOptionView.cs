using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ProductItemOptionView
    {
        public int ItemOptionId { get; set; }
        public string ItemOptionName { get; set; }
        public string ItemOptionPrice { get; set; }
    }
}
