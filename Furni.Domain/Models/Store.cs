using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Store
    {
        public Store()
        {
            CategoryTbl = new HashSet<CategoryTbl>();
            ItemAddOn = new HashSet<ItemAddOn>();
            ItemOption = new HashSet<ItemOption>();
            OrderDetails = new HashSet<OrderDetails>();
            PayToStoreFromDriver = new HashSet<PayToStoreFromDriver>();
            ProductNew = new HashSet<ProductNew>();
            StoreAddress = new HashSet<StoreAddress>();
            StoreAvailableCuisineTbl = new HashSet<StoreAvailableCuisineTbl>();
            StoreBankDetails = new HashSet<StoreBankDetails>();
            StoreDocument = new HashSet<StoreDocument>();
            StoreOffer = new HashSet<StoreOffer>();
            StoreOrder = new HashSet<StoreOrder>();
            StorePreferableDriverMapping = new HashSet<StorePreferableDriverMapping>();
            StoreTimeSlot = new HashSet<StoreTimeSlot>();
        }

        public int SId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneCode { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string ContactPerson { get; set; }
        public string Vat { get; set; }
        public string Image { get; set; }
        public int? LangId { get; set; }
        public int? CurId { get; set; }
        public int? Status { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? VerifyEmail { get; set; }
        public int? VerifyPhone { get; set; }
        public int? Delete { get; set; }
        public string AccessToken { get; set; }
        public int? MaxItemsInCart { get; set; }
        public decimal? MinOrderPrice { get; set; }
        public string CountryCode { get; set; }
        public bool? AcceptOrder { get; set; }
        public decimal? AdditionalCharges { get; set; }
        public int? EstimateTime { get; set; }
        public decimal? CostPerPerson { get; set; }
        public bool? IsLogedIn { get; set; }
        public string SocialId { get; set; }
        public string SocialType { get; set; }
        public int? ServiceTypeId { get; set; }
        public bool? TakeAway { get; set; }
        public bool? IsProfileVerified { get; set; }
        public bool? IsRejected { get; set; }
        public string Reason { get; set; }

        public virtual Currancy Cur { get; set; }
        public virtual Languages Lang { get; set; }
        public virtual ServiceTypetbl ServiceType { get; set; }
        public virtual ICollection<CategoryTbl> CategoryTbl { get; set; }
        public virtual ICollection<ItemAddOn> ItemAddOn { get; set; }
        public virtual ICollection<ItemOption> ItemOption { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<PayToStoreFromDriver> PayToStoreFromDriver { get; set; }
        public virtual ICollection<ProductNew> ProductNew { get; set; }
        public virtual ICollection<StoreAddress> StoreAddress { get; set; }
        public virtual ICollection<StoreAvailableCuisineTbl> StoreAvailableCuisineTbl { get; set; }
        public virtual ICollection<StoreBankDetails> StoreBankDetails { get; set; }
        public virtual ICollection<StoreDocument> StoreDocument { get; set; }
        public virtual ICollection<StoreOffer> StoreOffer { get; set; }
        public virtual ICollection<StoreOrder> StoreOrder { get; set; }
        public virtual ICollection<StorePreferableDriverMapping> StorePreferableDriverMapping { get; set; }
        public virtual ICollection<StoreTimeSlot> StoreTimeSlot { get; set; }
    }
}
