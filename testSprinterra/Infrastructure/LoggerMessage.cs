using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using testSprinterra.Interfaces;

namespace testSprinterra
{
    public class LoggerMessage : ILoggerMessage
    {
        private LogLevel _logLevel;
        private string _message;
        private DateTime _logDateTime;
        public LogLevel Level  { get => _logLevel; }

        public DateTime LogDateTime { get => _logDateTime; }

        public string Message { get => _message; }

        public LoggerMessage(LogLevel level, string message)
        {
            _logLevel = level;
            this._message = message;
            _logDateTime = DateTime.Now;
        }

        public override string ToString() => $"{LogDateTime.ToString()}\t{Level, -15}{Message}";
    }
}
