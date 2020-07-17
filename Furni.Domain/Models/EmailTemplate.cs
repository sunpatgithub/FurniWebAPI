using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class EmailTemplate
    {
        public int Id { get; set; }
        public string Purpose { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
