using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Settingtbl
    {
        public int Id { get; set; }
        public string Key1 { get; set; }
        public string Value { get; set; }
        public int? Delete { get; set; }
    }
}
