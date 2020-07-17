using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class EmailLang
    {
        public int EmailLangId { get; set; }
        public int? EmailId { get; set; }
        public int? LangId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
