using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ItemType
    {
        public int ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
