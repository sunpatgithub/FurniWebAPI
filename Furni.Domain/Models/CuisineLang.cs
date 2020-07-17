using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class CuisineLang
    {
        public int Id { get; set; }
        public string CuisineName { get; set; }
        public int LangId { get; set; }
        public int CuisineId { get; set; }

        public virtual CuisineTbl Cuisine { get; set; }
    }
}
