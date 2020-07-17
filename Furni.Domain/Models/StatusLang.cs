using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StatusLang
    {
        public int StatusId { get; set; }
        public int? Oid { get; set; }
        public int? LangId { get; set; }
        public string StatusName { get; set; }
        public string StatusDesc { get; set; }

        public virtual OrderStatus O { get; set; }
    }
}
