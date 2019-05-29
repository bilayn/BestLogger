using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testSprinterra.Interfaces;

namespace testSprinterra
{
    public class Logger : LoggerBase
    {
        private IWriter _writer;

        public Logger(IWriter writer) => this._writer = writer; 

        protected override void WriteLog(LogLevel level, string message) => _writer.Write(new LoggerMessage(level, message));
    }
}
