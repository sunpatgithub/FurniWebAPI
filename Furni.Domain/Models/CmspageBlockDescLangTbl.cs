using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CmspageBlockDescLangTbl
    {
        public int CmslangId { get; set; }
        public int? Cmsid { get; set; }
        public int? LangId { get; set; }
        public string PageBlock { get; set; }
        public string PageBlockDescription { get; set; }
    }
}
