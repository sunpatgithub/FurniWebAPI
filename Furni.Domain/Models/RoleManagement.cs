using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class RoleManagement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Model { get; set; }
        public int? Delete { get; set; }
    }
}
