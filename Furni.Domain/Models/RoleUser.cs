using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class RoleUser
    {
        public int RoleUserId { get; set; }
        public int? RId { get; set; }
        public int? UserId { get; set; }
        public int? Delete { get; set; }
        public bool? IsDeliveryCompany { get; set; }
    }
}
