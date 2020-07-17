using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DocumentFor
    {
        public int DocForId { get; set; }
        public string DocForName { get; set; }
        public bool? IsActive { get; set; }
    }
}
