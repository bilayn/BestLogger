using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testSprinterra.Interfaces;

namespace testSprinterra
{
    public static class LoggerService
    {
        private static readonly Lazy<Interfaces.ILogger> _logger;
        private static readonly Lazy<IBatchLogger> _batchLogger;

        static LoggerService()
        {
            var fileName = $"Log_{DateTime.Now.ToFileTime()}.txt";
            var writer = new Lazy<IBatchWriter>(() => new WritePool(new List<IWriter> { new ConsoleWriter(), new FileLogWriter(fileName) }));
            _logger = new Lazy<Interfaces.ILogger>(() => new Logger(writer.Value));
            _batchLogger = new Lazy<IBatchLogger>(() => new BatchLogger(writer.Value));
        }

        public static Interfaces.ILogger GetLogger() => _logger.Value;
        public static IBatchLogger GetBatchLogger() => _batchLogger.Value;
    }
}
