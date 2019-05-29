using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using testSprinterra.Interfaces;

namespace testSprinterra
{
    class BatchLogger : IBatchLogger
    {
        private IBatchWriter _writer;
        private List<ILoggerMessage> loggerMesages;

        public void Debug(string message) => loggerMesages.Add(new LoggerMessage(LogLevel.Debug, message));

        public void Error(string message) => loggerMesages.Add(new LoggerMessage(LogLevel.Error, message));

        public void Fatal(string message) => loggerMesages.Add(new LoggerMessage(LogLevel.Critical, message));

        public void Info(string message) => loggerMesages.Add(new LoggerMessage(LogLevel.Information, message));

        public void Warn(string message) => loggerMesages.Add(new LoggerMessage(LogLevel.Warning, message));

        public void Flush()
        {
            _writer.Write(loggerMesages);
            loggerMesages.Clear();
        }

        public BatchLogger(IBatchWriter writer)
        {
            this._writer = writer;
            loggerMesages = new List<ILoggerMessage>();
        }
    }
}
