using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class DeviceTokenTbl
    {
        public int DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceToken { get; set; }
        public string UserLoginType { get; set; }
        public int UserLoginId { get; set; }
    }
}
