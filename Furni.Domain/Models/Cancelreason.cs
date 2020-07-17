using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Cancelreason
    {
        public Cancelreason()
        {
            CancelLang = new HashSet<CancelLang>();
        }

        public int Cid { get; set; }
        public string Reason { get; set; }
        public int? Status { get; set; }
        public int? Orderid { get; set; }
        public int? Delete { get; set; }

        public virtual ICollection<CancelLang> CancelLang { get; set; }
    }
}
