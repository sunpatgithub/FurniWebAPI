using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Faq
    {
        public Faq()
        {
            FaqLang = new HashSet<FaqLang>();
        }

        public int FaqId { get; set; }
        public int? CatId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int? DisplayOrder { get; set; }
        public int? Status { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Delete { get; set; }

        public virtual ICollection<FaqLang> FaqLang { get; set; }
    }
}
