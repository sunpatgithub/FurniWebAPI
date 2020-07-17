using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class View2
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Location { get; set; }
        public decimal Ratings { get; set; }
        public string Distance { get; set; }
        public string CuisineName { get; set; }
        public string MinOrder { get; set; }
        public string PerPerson { get; set; }
        public string EstFoodPrepTime { get; set; }
        public string Offer { get; set; }
        public string StoreImage { get; set; }
    }
}
