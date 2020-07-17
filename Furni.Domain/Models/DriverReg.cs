using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DriverReg
    {
        public DriverReg()
        {
            CodtransferDetails = new HashSet<CodtransferDetails>();
            DriverAddress = new HashSet<DriverAddress>();
            DriverBankDetails = new HashSet<DriverBankDetails>();
            DriverCurrentLatLongtbl = new HashSet<DriverCurrentLatLongtbl>();
            DriverDocument = new HashSet<DriverDocument>();
            DriverTimeSlot = new HashSet<DriverTimeSlot>();
            PayToStoreFromDriver = new HashSet<PayToStoreFromDriver>();
            StorePreferableDriverMapping = new HashSet<StorePreferableDriverMapping>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int DId { get; set; }
        public int? SId { get; set; }
        public string DFname { get; set; }
        public string DLname { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
        public string PhoneCode { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int? CurId { get; set; }
        public int? Status { get; set; }
        public int? LangId { get; set; }
        public int? VerifyEmail { get; set; }
        public int? VerifyPhone { get; set; }
        public DateTime? RegDate { get; set; }
        public int? Delete { get; set; }
        public string AccessToken { get; set; }
        public string CountryCode { get; set; }
        public bool? IsOnline { get; set; }
        public bool? IsLogedIn { get; set; }
        public string SocialId { get; set; }
        public string SocialType { get; set; }
        public bool? IsProfileVerified { get; set; }
        public bool? IsRejected { get; set; }
        public string Reason { get; set; }
        public int? DriverCompanyId { get; set; }

        public virtual Currancy Cur { get; set; }
        public virtual Languages Lang { get; set; }
        public virtual ICollection<CodtransferDetails> CodtransferDetails { get; set; }
        public virtual ICollection<DriverAddress> DriverAddress { get; set; }
        public virtual ICollection<DriverBankDetails> DriverBankDetails { get; set; }
        public virtual ICollection<DriverCurrentLatLongtbl> DriverCurrentLatLongtbl { get; set; }
        public virtual ICollection<DriverDocument> DriverDocument { get; set; }
        public virtual ICollection<DriverTimeSlot> DriverTimeSlot { get; set; }
        public virtual ICollection<PayToStoreFromDriver> PayToStoreFromDriver { get; set; }
        public virtual ICollection<StorePreferableDriverMapping> StorePreferableDriverMapping { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
