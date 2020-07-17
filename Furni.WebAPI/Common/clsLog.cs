using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;

namespace Furni.WebAPI.Common
{
    static public class clsLog
    {
        static public string AddLog(string methodName, RouteData routeData)
        {
            var vControllerName = routeData.Values["controller"];
            var vActionName = routeData.Values["action"];
            var vMessage = String.Format("{0} controller:{1} action:{2}", methodName, vControllerName, vActionName);
            return vMessage;
        }
    }
}
