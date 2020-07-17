using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class FeedbackTbl
    {
        public int FeedbackId { get; set; }
        public string Remarks { get; set; }
        public int? Id { get; set; }
        public string Type { get; set; }
        public bool? IsDelete { get; set; }
    }
}
