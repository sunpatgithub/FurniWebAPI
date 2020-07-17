using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CategoryTbl
    {
        public CategoryTbl()
        {
            CategoryLang = new HashSet<CategoryLang>();
            ProductNew = new HashSet<ProductNew>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public int? DisplayOrder { get; set; }
        public string Image { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }
        public int? SId { get; set; }

        public virtual Store S { get; set; }
        public virtual ICollection<CategoryLang> CategoryLang { get; set; }
        public virtual ICollection<ProductNew> ProductNew { get; set; }
    }
}
