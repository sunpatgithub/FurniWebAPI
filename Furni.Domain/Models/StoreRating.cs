using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class StoreRating
    {
        public int SRId { get; set; }
        public int? SId { get; set; }
        public string Rating { get; set; }
        public string Review { get; set; }
        public string Type { get; set; }
        public int? Id { get; set; }
        public DateTime? RatingDate { get; set; }
        public int? Delete { get; set; }
    }
}
