﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Logging
{
    public sealed class Logger : Application.Interfaces.ILogger
    {

        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);
        private static readonly Lazy<Logger> _loggerInstance = new Lazy<Logger>(() => new Logger());

        private const string ExceptionName = "Exception";
        private const string InnerExceptionName = "Inner Exception";
        private const string ExceptionMessageWithoutInnerException = "{0}{1}: {2}Message: {3}{4}StackTrace: {5}.";
        private const string ExceptionMessageWithInnerException = "{0}{1}{2}";

    
        public static Logger Instance
        {
            get { return _loggerInstance.Value; }
        }
   
        public void Debug(object message)
        {
            if (_logger.IsDebugEnabled)
                _logger.Debug(message);
        }

        public void Info(object message)
        {
            if (_logger.IsInfoEnabled)
                _logger.Info(message);
        }

   
        public void Warn(object message)
        {
            if (_logger.IsWarnEnabled)
                _logger.Warn(message);
        }

        public void Error(object message)
        {
            _logger.Error(message);
        }

   
        public void Fatal(object message)
        {
            _logger.Fatal(message);
        }

 
        public void Debug(object message, Exception exception)
        {
            if (_logger.IsDebugEnabled)
                _logger.Debug(message, exception);
        }

 
        public void Info(object message, Exception exception)
        {
            if (_logger.IsInfoEnabled)
                _logger.Info(message, exception);
        }

 
        public void Warn(object message, Exception exception)
        {
            if (_logger.IsWarnEnabled)
                _logger.Info(message, exception);
        }

  
        public void Error(object message, Exception exception)
        {
            _logger.Error(message, exception);
        }


        public void Fatal(object message, Exception exception)
        {
            _logger.Fatal(message, exception);
        }

    
        public void Error(Exception exception)
        {
            _logger.Error(SerializeException(exception, ExceptionName));
        }

     
        public void Fatal(Exception exception)
        {
            _logger.Fatal(SerializeException(exception, ExceptionName));
        }

        private void TryLog(Action logAction)
        {
            try
            {
                logAction();  
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Logging failed: {ex.Message}");  
            }
        }

        public static string SerializeException(Exception exception)
        {
            return SerializeException(exception, string.Empty);
        }

      
        private static string SerializeException(Exception ex, string exceptionMessage)
        {
            var mesgAndStackTrace = string.Format(ExceptionMessageWithoutInnerException, Environment.NewLine,
                exceptionMessage, Environment.NewLine, ex.Message, Environment.NewLine, ex.StackTrace);

            if (ex.InnerException != null)
            {
                mesgAndStackTrace = string.Format(ExceptionMessageWithInnerException, mesgAndStackTrace,
                    Environment.NewLine,
                    SerializeException(ex.InnerException, InnerExceptionName));
            }

            return mesgAndStackTrace + Environment.NewLine;
        }

       
    }

}
