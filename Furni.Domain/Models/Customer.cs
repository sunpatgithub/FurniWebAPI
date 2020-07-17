using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Customer
    {
        public Customer()
        {
            PaymentResponse = new HashSet<PaymentResponse>();
        }

        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
        public string PhoneCode { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int? LangId { get; set; }
        public int? CountryId { get; set; }
        public int? CurId { get; set; }
        public int? Status { get; set; }
        public int? VerifyEmail { get; set; }
        public int? VerifyPhone { get; set; }
        public DateTime? RegDate { get; set; }
        public int? Delete { get; set; }
        public string CountryCode { get; set; }
        public string AccessToken { get; set; }
        public string SocialId { get; set; }
        public string SocialType { get; set; }
        public bool? IsLogedIn { get; set; }

        public virtual ICollection<PaymentResponse> PaymentResponse { get; set; }
    }
}
