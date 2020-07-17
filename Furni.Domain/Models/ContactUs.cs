using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ContactUs
    {
        public int ContactId { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string PhoneCode { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public int? LangId { get; set; }
    }
}
