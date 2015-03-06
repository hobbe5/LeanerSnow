using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanerSnow.Core.Logging
{
    public class LogHelper
    {
        public static void logException(object myclass, Exception e)
        {
            String className = myclass.GetType().ToString();
            Logger logger = LogManager.GetLogger(myclass.GetType().ToString());
            logger.ErrorException("Exception:  " + e.InnerException.Message, e);
        }

        public static void logException(string className, Exception e)
        {
            Logger logger = LogManager.GetLogger(className);
            logger.ErrorException("An exception has occurred in " + className, e);
        }

        public static void logVerboseException(object myclass, Exception e)
        {
            String className = myclass.GetType().ToString();
            Logger logger = LogManager.GetLogger(myclass.GetType().ToString());
            logger.ErrorException("Exception:  " + e.ToString(), e);
        }

        public static void logVerboseException(string className, Exception e)
        {
            Logger logger = LogManager.GetLogger(className);
            logger.ErrorException("An exception has occurred in " + className + " with Exception:  " + e.ToString(), e);
        }

        public static void logError(object myclass, String msg, Exception e)
        {
            Logger logger = LogManager.GetLogger(myclass.GetType().ToString());
            logger.Error(msg, e);
        }

        public static void logError(string className, String msg, Exception e)
        {
            Logger logger = LogManager.GetLogger(className);
            logger.Error(msg, e);
        }

        public static void logError(object myclass, String msg)
        {
            Logger logger = LogManager.GetLogger(myclass.GetType().ToString());
            logger.Error(msg);
        }

        public static void logError(string className, String msg)
        {
            Logger logger = LogManager.GetLogger(className);
            logger.Error(msg);
        }

        public static void logDebug(object myclass, String msg)
        {
            Logger logger = LogManager.GetLogger(myclass.GetType().ToString());
            logger.Debug(msg);
        }

        public static void logDebug(string className, String msg)
        {
            Logger logger = LogManager.GetLogger(className);
            logger.Debug(msg);
        }

        public static void logWarn(object myclass, String msg)
        {
            Logger logger = LogManager.GetLogger(myclass.GetType().ToString());
            logger.Warn(msg);
        }

        public static void logWarn(string className, String msg)
        {
            Logger logger = LogManager.GetLogger(className);
            logger.Warn(msg);
        }

        public static void logInfo(object myclass, String msg)
        {
            Logger logger = LogManager.GetLogger(myclass.GetType().ToString());
            logger.Info(msg);
        }

        public static void logInfo(string className, String msg)
        {
            Logger logger = LogManager.GetLogger(className);
            logger.Info(msg);
        }

        public static void logTrace(object myclass, String msg)
        {
            Logger logger = LogManager.GetLogger(myclass.GetType().ToString());
            logger.Trace(msg);
        }

        public static void logTrace(string className, String msg)
        {
            Logger logger = LogManager.GetLogger(className);
            logger.Trace(msg);
        }
    }
}
