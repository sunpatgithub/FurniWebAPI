using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CategoryLang
    {
        public int CategoryId { get; set; }
        public int? CatId { get; set; }
        public int? LangId { get; set; }
        public string CatName { get; set; }
        public int? Delete { get; set; }

        public virtual CategoryTbl Cat { get; set; }
        public virtual Languages Lang { get; set; }
    }
}
