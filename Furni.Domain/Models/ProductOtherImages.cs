using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ProductOtherImages
    {
        public int ProductImageId { get; set; }
        public long? ProductId { get; set; }
        public string ProductImageName { get; set; }
        public int? IsActive { get; set; }
    }
}
