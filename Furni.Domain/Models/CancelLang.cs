using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CancelLang
    {
        public int CancelId { get; set; }
        public int? Cid { get; set; }
        public string Reason { get; set; }
        public int? LangId { get; set; }

        public virtual Cancelreason C { get; set; }
    }
}
