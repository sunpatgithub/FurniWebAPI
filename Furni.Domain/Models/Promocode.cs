using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Promocode
    {
        public Promocode()
        {
            PromocodeLang = new HashSet<PromocodeLang>();
        }

        public int Pid { get; set; }
        public string Giftcode { get; set; }
        public string Discount { get; set; }
        public string Validity { get; set; }
        public DateTime? Activationdate { get; set; }
        public DateTime? Expirydate { get; set; }
        public int? Usagelimit { get; set; }
        public int? Used { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }
        public string Type1 { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PromocodeLang> PromocodeLang { get; set; }
    }
}
