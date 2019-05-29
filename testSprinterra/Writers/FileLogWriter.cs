using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testSprinterra.Interfaces;

namespace testSprinterra
{
    class FileLogWriter : IBatchWriter
    {
        private string _file;
        public void Write(List<ILoggerMessage> messages)
        {
           
            using (StreamWriter sw = new StreamWriter(_file, true, Encoding.Default))
            {
                foreach (var message in messages)
                {
                    sw.WriteLine(message.ToString());
                }
            }

        }

        public void Write(ILoggerMessage message)
        {
            using (StreamWriter sw = new StreamWriter(_file, true, Encoding.Default))
            {
                sw.WriteLine(message.ToString());
            }
        }

        public FileLogWriter(string fileName) => this._file = fileName;
    }
}
