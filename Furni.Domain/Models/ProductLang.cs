using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ProductLang
    {
        public int Id { get; set; }
        public long? Pid { get; set; }
        public int? LangId { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int? Delete { get; set; }
    }
}
