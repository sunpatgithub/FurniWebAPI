using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            StatusLang = new HashSet<StatusLang>();
        }

        public int Oid { get; set; }
        public string StatusName { get; set; }
        public string StatusDesc { get; set; }
        public string StatusColor { get; set; }
        public int? StatusId { get; set; }

        public virtual ICollection<StatusLang> StatusLang { get; set; }
    }
}
