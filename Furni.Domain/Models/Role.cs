using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Role
    {
        public int RId { get; set; }
        public string RoleName { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }
    }
}
