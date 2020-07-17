using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ItemTag
    {
        public int ItemTagId { get; set; }
        public string ItemTagName { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
