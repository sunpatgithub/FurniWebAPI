using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class FaqCategoryLang
    {
        public int CatLangId { get; set; }
        public int? CatId { get; set; }
        public int? LangId { get; set; }
        public string CatLable { get; set; }

        public virtual FaqCategory Cat { get; set; }
    }
}
