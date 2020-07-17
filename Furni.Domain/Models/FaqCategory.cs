using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class FaqCategory
    {
        public FaqCategory()
        {
            FaqCategoryLang = new HashSet<FaqCategoryLang>();
        }

        public int CatId { get; set; }
        public string CatLable { get; set; }
        public int? DisplayOrder { get; set; }
        public int? Status { get; set; }
        public int? AddedBy { get; set; }
        public int? Delete { get; set; }

        public virtual ICollection<FaqCategoryLang> FaqCategoryLang { get; set; }
    }
}
