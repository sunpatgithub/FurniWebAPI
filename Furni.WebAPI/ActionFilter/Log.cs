using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.Reflection;
using Furni.WebAPI.Common;


namespace Furni.WebAPI.ActionFilter
{
    [AttributeUsage(AttributeTargets.Class)]
    public class Log : ActionFilterAttribute, IExceptionFilter
    {
        private static readonly ILog Logfile = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Trace.WriteLine(clsLog.AddLog("OnActionExecuting", filterContext.RouteData));
            Logfile.Info(clsLog.AddLog("OnActionExecuting", filterContext.RouteData));
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Trace.TraceWarning(clsLog.AddLog("OnActionExecuted", filterContext.RouteData));
            Logfile.Warn(clsLog.AddLog("OnActionExecuted", filterContext.RouteData));
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //Trace.TraceInformation(clsLog.AddLog("OnResultExecuting", filterContext.RouteData));
            Logfile.Info(clsLog.AddLog("OnResultExecuted", filterContext.RouteData));
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //Trace.TraceWarning(clsLog.AddLog("OnResultExecuted", filterContext.RouteData));
            Logfile.Warn(clsLog.AddLog("OnResultExecuted", filterContext.RouteData));
        }

        public void OnException(ExceptionContext exceptionContext)
        {
            //Trace.TraceError(clsLog.AddLog("OnException", exceptionContext.RouteData));
            Logfile.Error(clsLog.AddLog("OnException", exceptionContext.RouteData));
        }
    }
}
