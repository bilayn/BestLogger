using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSprinterra.Interfaces
{
    public interface IBatchWriter : IWriter
    {
        void Write(List<ILoggerMessage> messages);
    }
}
