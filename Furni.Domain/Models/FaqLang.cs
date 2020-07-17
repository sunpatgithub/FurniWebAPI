using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class FaqLang
    {
        public int FaqlangId { get; set; }
        public int? FaqId { get; set; }
        public int? LangId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public virtual Faq Faq { get; set; }
    }
}
