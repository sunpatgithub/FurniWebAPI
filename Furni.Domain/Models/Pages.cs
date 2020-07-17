using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Pages
    {
        public int PageId { get; set; }
        public string Type { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public int? DisplayOrder { get; set; }
        public int? Status { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Mobile { get; set; }
    }
}
