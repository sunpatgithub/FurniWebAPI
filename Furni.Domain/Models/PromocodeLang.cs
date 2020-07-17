using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class PromocodeLang
    {
        public int PromoLangId { get; set; }
        public int Pid { get; set; }
        public string Description { get; set; }
        public int? LangId { get; set; }

        public virtual Promocode P { get; set; }
    }
}
