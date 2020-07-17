using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StoreDocument
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int DocMgmtId { get; set; }
        public DateTime? DocExpiryDate { get; set; }
        public string UploadedDocFileName { get; set; }
        public bool IsDocVerified { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Status { get; set; }
        public bool IsDeleted { get; set; }
        public string Reason { get; set; }
        public bool? IsRejected { get; set; }

        public virtual ManageDocument DocMgmt { get; set; }
        public virtual Store Store { get; set; }
    }
}
