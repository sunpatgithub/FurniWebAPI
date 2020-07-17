using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CmspageBlockDescTbl
    {
        public int Cmsid { get; set; }
        public int CmspageId { get; set; }
        public string PageBlock { get; set; }
        public string PageBlockDescription { get; set; }
    }
}
