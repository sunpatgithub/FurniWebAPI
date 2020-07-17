using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class VwGetFullStoreDetails
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string ContactPerson { get; set; }
        public string StoreImage { get; set; }
        public int Status { get; set; }
        public int MaxOrderQty { get; set; }
        public string MinOrder { get; set; }
        public bool AcceptOrder { get; set; }
        public decimal AdditionalCharges { get; set; }
        public string EstFoodPrepTime { get; set; }
        public string OfferAppliesOn { get; set; }
        public decimal MaxAmount { get; set; }
        public string OfferApply { get; set; }
        public decimal OfferDiscount { get; set; }
        public string OfferType { get; set; }
        public decimal TargetAmount { get; set; }
        public string CostPerPerson { get; set; }
        public int AddressId { get; set; }
        public string Location { get; set; }
        public string AddressLine { get; set; }
        public string ZipCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public decimal Ratings { get; set; }
        public string Distance { get; set; }
        public double? DistanceWithoutUnit { get; set; }
        public string CuisineName { get; set; }
        public string CuisineIds { get; set; }
        public string AcceptOrderText { get; set; }
        public string StoreBusinessHoursText { get; set; }
        public int IsStoreInBusinessHours { get; set; }
        public int ServiceTypeId { get; set; }
        public bool IsSelfPickup { get; set; }
    }
}
