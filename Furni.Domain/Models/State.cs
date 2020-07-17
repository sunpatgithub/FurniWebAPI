using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class State
    {
        public State()
        {
            DriverAddress = new HashSet<DriverAddress>();
            StoreAddress = new HashSet<StoreAddress>();
        }

        public int StateId { get; set; }
        public int? CountryId { get; set; }
        public string StateName { get; set; }
        public int? Status { get; set; }
        public int? Delete { get; set; }

        public virtual ICollection<DriverAddress> DriverAddress { get; set; }
        public virtual ICollection<StoreAddress> StoreAddress { get; set; }
    }
}
