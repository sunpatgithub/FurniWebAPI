using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class Notificationtbl
    {
        public long NotificationId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime? SendDate { get; set; }
        public string UserType { get; set; }
        public int? UserLoginId { get; set; }
        public string DeviceToken { get; set; }
        public string DeviceType { get; set; }
        public bool? IsRead { get; set; }
        public long? RefId { get; set; }
        public string NotificationType { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
    }
}
