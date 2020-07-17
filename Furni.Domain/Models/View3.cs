using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class View3
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreImage { get; set; }
        public string CuisineName { get; set; }
        public string MinOrder { get; set; }
        public string PerPerson { get; set; }
        public string EstFoodPrepTime { get; set; }
        public decimal AvgReview { get; set; }
        public bool AcceptOrder { get; set; }
        public string Distance { get; set; }
        public string DistanceWithoutUnit { get; set; }
        public string Offer { get; set; }
    }
}
