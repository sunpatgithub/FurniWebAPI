using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class PageLang
    {
        public int PageLangId { get; set; }
        public int PageId { get; set; }
        public int? LangId { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
    }
}
