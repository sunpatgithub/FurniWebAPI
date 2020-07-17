using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CmspageTbl
    {
        public int CmspageId { get; set; }
        public string PageName { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
