﻿using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ProductOption
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string OptionName { get; set; }
        public double? Price { get; set; }
        public int? Delete { get; set; }
    }
}
