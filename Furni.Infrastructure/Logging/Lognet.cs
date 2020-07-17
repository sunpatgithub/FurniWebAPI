using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace OnlineTrackingSystem.Infrastructure.Logging
{
    public class Lognet : ILognet
    {
        private ILog logger;
        private bool isConfigured = false;

        public Lognet()
        {
            if (!isConfigured)
            {
                logger = LogManager.GetLogger(typeof(Lognet));
                //readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                log4net.Config.XmlConfigurator.Configure();
            }
        }

        public ILog Logger()
        {
            return logger;
            
        }

    }
}
