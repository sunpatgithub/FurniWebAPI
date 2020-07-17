using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ItemTypeLang
    {
        public int ItemTypeLangId { get; set; }
        public int? ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
        public int? LangId { get; set; }
    }
}
