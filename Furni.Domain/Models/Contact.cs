﻿using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
    }
}
