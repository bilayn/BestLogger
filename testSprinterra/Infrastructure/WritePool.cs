using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testSprinterra.Interfaces;

namespace testSprinterra
{
    public class WritePool : IBatchWriter
    {
        private IEnumerable<IWriter> _writers;

        public void Write(List<ILoggerMessage> messages)
        {
            foreach (var writer in _writers)
            {
                foreach(var msg in messages)
                {
                    writer.Write(msg);
                }
            }
        }

        public void Write(ILoggerMessage message)
        {
            foreach(var writer in _writers)
            {
                writer.Write(message);
            }
        }

        public WritePool(IEnumerable<IWriter> writers) => this._writers = writers;
    }
}
