using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Languages
    {
        public Languages()
        {
            CategoryLang = new HashSet<CategoryLang>();
            DeliveryCompany = new HashSet<DeliveryCompany>();
            DriverReg = new HashSet<DriverReg>();
            ManageDocLang = new HashSet<ManageDocLang>();
            Store = new HashSet<Store>();
        }

        public int LangId { get; set; }
        public string Name { get; set; }
        public string LangCode { get; set; }
        public string FlagIcon { get; set; }
        public int? BaseLanguage { get; set; }
        public string Style { get; set; }
        public int? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Delete { get; set; }

        public virtual ICollection<CategoryLang> CategoryLang { get; set; }
        public virtual ICollection<DeliveryCompany> DeliveryCompany { get; set; }
        public virtual ICollection<DriverReg> DriverReg { get; set; }
        public virtual ICollection<ManageDocLang> ManageDocLang { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
