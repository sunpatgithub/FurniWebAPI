using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CustomerRating
    {
        public int CRId { get; set; }
        public int? CustId { get; set; }
        public string Rating { get; set; }
        public string Review { get; set; }
        public string Type { get; set; }
        public int? Id { get; set; }
        public DateTime? RatingDate { get; set; }
        public int? Delete { get; set; }
    }
}
