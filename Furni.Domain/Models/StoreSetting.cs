using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StoreSetting
    {
        public int Id { get; set; }
        public string SKey { get; set; }
        public int? Value { get; set; }
        public int? Delete { get; set; }
    }
}
