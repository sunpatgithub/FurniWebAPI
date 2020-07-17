using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class TblEmployees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }
    }
}
