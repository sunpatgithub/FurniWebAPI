using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class LoginLog
    {
        public int LId { get; set; }
        public int? Id { get; set; }
        public string Type { get; set; }
        public DateTime? Time { get; set; }
        public string IpAdd { get; set; }
        public string Platform { get; set; }
        public int? Delete { get; set; }
    }
}
