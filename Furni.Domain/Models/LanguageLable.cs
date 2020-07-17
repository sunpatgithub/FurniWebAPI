using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class LanguageLable
    {
        public int Id { get; set; }
        public int? LangId { get; set; }
        public string LableKey { get; set; }
        public string LableValue { get; set; }
        public int? Delete { get; set; }
    }
}
