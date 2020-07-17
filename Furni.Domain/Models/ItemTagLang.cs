using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ItemTagLang
    {
        public int ItemTagLangId { get; set; }
        public int? ItemTagId { get; set; }
        public string ItemTagName { get; set; }
        public int? LangId { get; set; }
    }
}
