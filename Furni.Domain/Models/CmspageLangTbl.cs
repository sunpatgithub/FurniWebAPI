using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CmspageLangTbl
    {
        public int CmspageLangId { get; set; }
        public int? CmspageId { get; set; }
        public int? LangId { get; set; }
        public string PageName { get; set; }
    }
}
