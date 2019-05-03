﻿using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pizza_Delivery
{
    public static class Logger
    {
        private static ILog log = LogManager.GetLogger("LOGGER");
        public static ILog Log
        {
            get { return log; }
        }
        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}