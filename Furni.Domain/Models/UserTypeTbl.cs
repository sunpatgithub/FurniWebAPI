using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class UserTypeTbl
    {
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public bool? Status { get; set; }
    }
}
