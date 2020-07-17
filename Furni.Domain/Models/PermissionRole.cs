using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class PermissionRole
    {
        public int PrId { get; set; }
        public int? RoleManId { get; set; }
        public int? RId { get; set; }
        public int? Delete { get; set; }
    }
}
