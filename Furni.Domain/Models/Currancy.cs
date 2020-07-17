using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Currancy
    {
        public Currancy()
        {
            DeliveryCompany = new HashSet<DeliveryCompany>();
            DriverReg = new HashSet<DriverReg>();
            Store = new HashSet<Store>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Delete { get; set; }

        public virtual ICollection<DeliveryCompany> DeliveryCompany { get; set; }
        public virtual ICollection<DriverReg> DriverReg { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
