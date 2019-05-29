using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSprinterra
{
    class Program
    {
        static void Main(string[] args)
        {

            // Simple Logger
            var logger = LoggerService.GetLogger();
            logger.Info("Simple logger: Infomessage");
            logger.Debug("Simple logger: Debug");
            logger.Error("Simple logger: Error");
            logger.Fatal("Simple logger: Fatal");
            logger.Warn("Simple logger: Warn");

            // Batch Logger
            var batchLogger = LoggerService.GetBatchLogger();
            batchLogger.Debug("Batch logger: Debug");
            batchLogger.Info("Batch logger: Info");
            batchLogger.Error("Batch logger: Error");
            batchLogger.Fatal("Batch logger: Fatal");
            batchLogger.Warn("Batch logger: Warn");
            batchLogger.Flush();
        }
    }
}
