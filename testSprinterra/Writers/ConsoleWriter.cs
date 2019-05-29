using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testSprinterra.Interfaces;

namespace testSprinterra
{
    class ConsoleWriter : IWriter
    {
        public void Write(ILoggerMessage message) => Console.WriteLine(message);
    }
}
