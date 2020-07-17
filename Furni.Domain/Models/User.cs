using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class User
    {
        public int UId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public string Password { get; set; }
        public int? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Delete { get; set; }
        public string AccessToken { get; set; }
        public int? LangId { get; set; }
        public int? CurId { get; set; }
        public string PhoneCode { get; set; }
        public string CountryCode { get; set; }
    }
}
