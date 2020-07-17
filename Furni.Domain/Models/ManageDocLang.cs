using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ManageDocLang
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public int LangId { get; set; }
        public int DocMgmtId { get; set; }

        public virtual ManageDocument DocMgmt { get; set; }
        public virtual Languages Lang { get; set; }
    }
}
