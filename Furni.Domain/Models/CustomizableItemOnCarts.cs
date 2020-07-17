using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CustomizableItemOnCarts
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public string ItemType { get; set; }
        public int ItemTypeId { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
