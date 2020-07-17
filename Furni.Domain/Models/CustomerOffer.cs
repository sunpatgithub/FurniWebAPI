using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CustomerOffer
    {
        public int Id { get; set; }
        public int? OfferId { get; set; }
        public int? CustId { get; set; }
        public int? Delete { get; set; }
    }
}
