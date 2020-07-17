using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DriverRating
    {
        public int DRId { get; set; }
        public int? DId { get; set; }
        public string Rating { get; set; }
        public string Review { get; set; }
        public string Type { get; set; }
        public int? Id { get; set; }
        public DateTime? RatingDate { get; set; }
        public int? Delete { get; set; }
    }
}
