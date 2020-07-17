using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DetailsTbl
    {
        public int DetailId { get; set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public string DetailName { get; set; }
    }
}
