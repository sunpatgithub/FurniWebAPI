﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace OnlineTrackingSystem.Infrastructure.Logging
{
    public interface ILognet
    {
        ILog Logger();
    }
}
