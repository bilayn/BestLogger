using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testSprinterra.Interfaces;

namespace testSprinterra
{
    public abstract class LoggerBase : Interfaces.ILogger
    {
        public void Debug(string message) => WriteLog(LogLevel.Debug, message);

        public void Error(string message) => WriteLog(LogLevel.Error, message);

        public void Fatal(string message) => WriteLog(LogLevel.Critical, message);

        public void Info(string message) => WriteLog(LogLevel.Information, message);

        public void Warn(string message) => WriteLog(LogLevel.Warning, message);


        protected LoggerMessage GetLoggerMessage(LogLevel level, string message) => new LoggerMessage(level, message);

        protected abstract void WriteLog(LogLevel level, string message);
    }
}
