﻿using System;
using log4net;
using System.Configuration;

namespace DeviceComm.Class
{
    public class CommonLogger
    {
        private static ILog log = LogManager.GetLogger(System.Configuration.ConfigurationManager.AppSettings["ActiveLogger"]);

        private CommonLogger()
        {

        }

        public static void Error(string message)
        {
            if (log.IsErrorEnabled)
                log.Error(message);

        }
        public static void Error(string message, System.Exception exception)
        {
            if (log.IsErrorEnabled)
                log.Error(message, exception);

        }

        public static void Info(string message)
        {
            if (log.IsInfoEnabled)
                log.Info("\r\n******************\r\n"+message+"\r\n***************\r\n");

        }
        public static void Info(string message, System.Exception exception)
        {
            if (log.IsInfoEnabled)
                log.Info(message, exception);

        }

        public static void Warn(string message)
        {
            if (log.IsWarnEnabled)
                log.Warn(message);
        }
        public static void Warn(string message, System.Exception exception)
        {
            if (log.IsWarnEnabled)
                log.Warn(message, exception);
        }

        public static void Debug(string message)
        {
            if (log.IsDebugEnabled)
                log.Debug(message);
        }
        public static void Debug(string message, System.Exception exception)
        {
            if (log.IsDebugEnabled)
                log.Debug(message, exception);
        }

        public static void Fatal(string message)
        {
            if (log.IsFatalEnabled)
                log.Fatal(message);
        }
        public static void Fatal(string message, System.Exception exception)
        {
            if (log.IsFatalEnabled)
                log.Fatal(message, exception);
        }

    }

}
