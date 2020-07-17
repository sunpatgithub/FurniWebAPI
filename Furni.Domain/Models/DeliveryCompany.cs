using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DeliveryCompany
    {
        public int DeliveryCompanyId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneCode { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string ContactPerson { get; set; }
        public string Vat { get; set; }
        public string Image { get; set; }
        public int? LangId { get; set; }
        public int? CurId { get; set; }
        public bool? Status { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? VerifyEmail { get; set; }
        public bool? VerifyPhone { get; set; }
        public bool? IsDeleted { get; set; }
        public string AccessToken { get; set; }
        public bool? IsProfileVerified { get; set; }
        public bool? IsRejected { get; set; }
        public string Reason { get; set; }
        public int ServiceTypeId { get; set; }

        public virtual Currancy Cur { get; set; }
        public virtual Languages Lang { get; set; }
    }
}
