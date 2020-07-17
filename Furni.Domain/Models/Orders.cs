using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Orders
    {
        public Orders()
        {
            PaymentResponse = new HashSet<PaymentResponse>();
            Paymenttbl = new HashSet<Paymenttbl>();
            StoreOrder = new HashSet<StoreOrder>();
        }

        public int Oid { get; set; }
        public int? CustId { get; set; }
        public int? SId { get; set; }
        public int? DId { get; set; }
        public int? Payid { get; set; }
        public string PaymentStatus { get; set; }
        public string DeliveryType { get; set; }
        public int? AddressId { get; set; }
        public string Notes { get; set; }
        public int? StatusId { get; set; }
        public string Reason { get; set; }
        public DateTime? PreferDatetime { get; set; }
        public int? OfferId { get; set; }
        public string PaymentMode { get; set; }
        public double? OrderSubtotal { get; set; }
        public double? Discount { get; set; }
        public double? Tax { get; set; }
        public double? DeliveryCharge { get; set; }
        public double? FinalTotal { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Delete { get; set; }
        public decimal? CancelCharge { get; set; }
        public string CancelBy { get; set; }
        public int? CancelId { get; set; }
        public DateTime? DeliverDate { get; set; }
        public double? PackageCharge { get; set; }
        public int? VehicleId { get; set; }
        public long? OrderBaseDetailId { get; set; }
        public double? OfferDiscount { get; set; }
        public bool? IsSetteled { get; set; }
        public bool? IsArriveToStore { get; set; }

        public virtual ICollection<PaymentResponse> PaymentResponse { get; set; }
        public virtual ICollection<Paymenttbl> Paymenttbl { get; set; }
        public virtual ICollection<StoreOrder> StoreOrder { get; set; }
    }
}
