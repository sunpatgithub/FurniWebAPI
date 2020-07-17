using System;
using System.Collections.Generic;

namespace Furni.Domain.Models
{
    public partial class ErrorLog
    {
        public int PkErrorLogId { get; set; }
        public string UserName { get; set; }
        public string Controller { get; set; }
        public string CurrentActionName { get; set; }
        public DateTime? ErrorDateTime { get; set; }
        public string ErrorType { get; set; }
        public string Ipaddress { get; set; }
        public string InnerException { get; set; }
        public string ClientBrowser { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorStackTrace { get; set; }
        public string Url { get; set; }
        public string Urlreferrer { get; set; }
        public string ErrorSource { get; set; }
        public string ErrorTargetSite { get; set; }
        public string QueryString { get; set; }
        public string PostData { get; set; }
        public string SessionInfo { get; set; }
    }
}
